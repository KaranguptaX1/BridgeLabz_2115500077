using System;
//Task Node class 
class TaskNode{
    //varible of tasks
    public int taskId;
    public string taskName;
    public int priority;
    public string dueDate;
    public TaskNode Next;//next pointer
    //Constructor
    public TaskNode(int taskId,string taskName,int priority,string dueDate){
        this.taskId=taskId;
        this.taskName=taskName;
        this.priority=priority;
        this.dueDate=dueDate;
        Next=this;
    }
}
//class for task linked list
class Tasks{
    //head pointer
    private TaskNode head;
    //method to  add task on basis of position
    public void AddTask(int taskId,string taskName,int priority,string dueDate,int position=-1){
        TaskNode task= new TaskNode(taskId,taskName,priority,dueDate);
        //if list is empty
        if(head==null){
            head=task;
            head.Next=head;
            return;
        }
        //add at first position
        if(position==0){
            TaskNode temp=head;
            while(temp.Next!=head){
                temp=temp.Next;
            }
            temp.Next=task;
            task.Next=head;
            head=task;
            return;
        }
        //add at last position
        if(position==-1){
            TaskNode temp=head;
            while(temp.Next!=head){
                temp=temp.Next;
            }
            task.Next=head;
            temp.Next=task;
            return;
        }
        //add at other position
        TaskNode prev=head;
        for(int i=0;i<position-1&&prev.Next!=head;i++){
            prev=prev.Next;
        }
        task.Next=prev.Next;
        prev.Next=task;
    }
    //method to remove task from list
    public void RemoveTask(int taskId){
        //if list is empty
        if(head==null){
            Console.WriteLine("No element in list");
            return;
        }
        //to remove first task
        if(head.taskId==taskId){
            TaskNode temp= head;
            while(temp.Next!=head){
                temp=temp.Next;
            }
            head=head.Next;
            temp.Next=head;
            return;
        }
        //to remove other position tasks
        TaskNode prev= head;
        while(prev.Next!=head && prev.Next.taskId!=taskId){
            prev=prev.Next;
        }
        if(prev.Next!=head){
            prev.Next=prev.Next.Next;
            return ;
        }
        Console.WriteLine($"No Element matched {taskId}");

    }
    //to view the tasks from list on taskid
    public void ViewTasksFrom(int taskId){
        //if there is no list
        if(head==null){
            Console.WriteLine("No element in list");
            return;
        }
        TaskNode temp=head;
        //move the temp pointer to task id
        while(temp.Next!=head && temp.taskId!=taskId){
            temp=temp.Next;
        }
        //loop to print the tasks from that task id to last
        while(temp.Next!=head){
            Console.WriteLine($"TaskId: {temp.taskId},TaskName: {temp.taskName},Priority: {temp.priority},dueDate: {temp.dueDate}.");
            Console.WriteLine("Press to move to other task.");
            Console.ReadLine();
            temp=temp.Next;
        }
        Console.WriteLine($"TaskId: {temp.taskId},TaskName: {temp.taskName},Priority: {temp.priority},dueDate: {temp.dueDate}.");
        Console.WriteLine("No More tasks.");

    }
    //method to display the task list
    public void Display(){
        TaskNode temp= head;
        while(temp.Next!=head){
            Console.WriteLine($"TaskId:{temp.taskId},Name:{temp.taskName}");
            temp=temp.Next;
        }
        Console.WriteLine($"TaskId:{temp.taskId},Name:{temp.taskName}");

    }
    //Search task by priority
    public TaskNode SearchTaskByPriority(int priority){
        if(head==null){
            Console.WriteLine("No Element in list.");
        }
        if(head.priority==priority){
            return head;
        }
        TaskNode temp=head.Next;
        while(temp!=head){
            if(temp.priority==priority){
                return temp;
            }
            temp=temp.Next;
        }
        return null;
    }
}
class Program{
    //Main method to call the instance and methods
    static void Main(string[] args){
        Tasks tasks= new Tasks();
        tasks.AddTask(1,"Gym",10,"20-02-2025");
        tasks.AddTask(2,"Cardio",6,"21-02-2025");
        tasks.AddTask(3,"Code",8,"20-02-2025",0);
        tasks.AddTask(4,"Anime",9,"19-04-2025");
        tasks.RemoveTask(1);
        // tasks.RemoveTask(4);
        tasks.ViewTasksFrom(3);
        tasks.Display();
        TaskNode search= tasks.SearchTaskByPriority(9);
        if(search!=null){
            Console.WriteLine(search.taskName);
        }


    }
}