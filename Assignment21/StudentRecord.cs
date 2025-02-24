using System;
//Node Class
class StudentNode{
    //variables for students
    public int rollNumber;
    public string name;
    public int age;
    public string grade;
    public StudentNode Next;
    //Constructor
    public StudentNode(int rollNumber,string name,int age,string grade){
        this.rollNumber=rollNumber;
        this.name=name;
        this.age=age;
        this.grade=grade;
        Next=null;
    }
}
//students class for Linked list
class Students{
    //head pointer
    public StudentNode head;
    //Add Students method by position to put at specified position
    public void AddStudents(int rollNumber,string name,int age,string grade,int position=-1){
        StudentNode student= new StudentNode(rollNumber,name,age,grade);
        //if list is empty or add at first position
        if(position==0 || head==null){
            student.Next=head;
            head=student;
            return;
        }
        //Add at last position
        if(position==-1){
            StudentNode temp=head;
            while(temp.Next!=null){
                temp=temp.Next;
            }
            temp.Next=student;
            return;
        }
        //Add at specified position
        StudentNode prev=head;
        for(int i=0;i<position-1&& prev.Next!=null;i++){
            prev=prev.Next;
        }
        student.Next=prev.Next;
        prev.Next=student;
        
    }
    //Method to delete students
    public void DeleteStudents(int rollNumber){
        //if list is empty
        if(head==null){
            Console.WriteLine("No element to delete.");
            return;
        }
        //first element is the element
        if(head.rollNumber==rollNumber){
            head=head.Next;
            return;
        }
        //remove from other position
        StudentNode temp= head;
        while(temp.Next!=null && temp.Next.rollNumber!=rollNumber){
            temp=temp.Next;
        }
        if(temp.Next!=null){
            temp.Next=temp.Next.Next;
        }
    }
    //method to search students
    public StudentNode SearchStudent(int rollNumber){
        StudentNode temp=head;
        while(temp!=null){
            if(temp.rollNumber==rollNumber){
                return temp;
            }
        temp=temp.Next;
        }
        return null;
    }
    //method to display students in list
    public void Display(){
        StudentNode temp= head;
        if(temp==null){
            Console.WriteLine("No element in list");
            return;
        }
        while(temp!=null){
            Console.WriteLine($"Roll Number:{temp.rollNumber},Name: {temp.name},Age:{temp.age},Grade:{temp.grade}");
            temp=temp.Next;
        }
    }
    //method to update grade from roll number
    public void UpgradeGrade(int rollNumber,string grade){
        StudentNode student = SearchStudent(rollNumber);
        if(student!=null){
            student.grade=grade;
        }
    }

}
class Program{
    //Main method to call the instance and methods
    static void Main(){
    Students studentList= new Students();
    studentList.AddStudents(1,"Abhishek",21,"A+");
    studentList.AddStudents(3,"Rahul Kumar",22,"A");
    studentList.AddStudents(2,"Bharat",21,"O",0);
    studentList.AddStudents(4,"Karan",20,"A-");
    studentList.Display();
    studentList.DeleteStudents(1);
    StudentNode search= studentList.SearchStudent(2);
    studentList.UpgradeGrade(2,"O+");
    Console.WriteLine(search.name);
    studentList.Display();
    }

}