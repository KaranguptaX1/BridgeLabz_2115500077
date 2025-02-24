using System;
namespace UniversityStudentManagement{
    class Student{
        //Initialize variables
        private static string UniversityName="GLA University";
        private string Name;
        private readonly int RollNumber;
        private string Grade;
        private static int TotalStudents=0;
        //method to display total number of students
        public static void DisplayTotalStudents(){
            //TotalStudents must be static as it is used inside static method
            Console.WriteLine($"The Total number of students: {TotalStudents}");
        }
        //Constructor
        public Student(string Name,int RollNumber,string Grade){
            this.Name=Name;
            this.RollNumber=RollNumber;
            this.Grade=Grade;
            TotalStudents++;
        }
        //Method to display student details
        public void DisplayStudentDetails(){
            Console.WriteLine($"University name: {UniversityName}");
            Console.WriteLine($"The student Roll number is :{RollNumber}");
            Console.WriteLine($"The name of Student: {Name}");
            Console.WriteLine($"The grade of student is: {Grade}");
            Console.WriteLine("---------------------------------------");
        }
        //Method to update Grade
        public void UpdateGrade( string newGrade){
            if (this is Student){
                // Only update the grade if the object is an instance of Student
                this.Grade = newGrade;
                Console.WriteLine($"Grade updated to {newGrade} for student: {this.Name}");
            }
            else
            {
                Console.WriteLine("The provided object is not a student.");
            }
        }
    }
//    class Library{
//        private string LibraryName;
//        public Library(){
//            this.LibraryName="123Libraray";
//        }
//    }
    class Program{
        static void Main(string[] args){
            //make the instance
            Student student1=new Student("Rahul Kumar",2115500117,"A");
            Student student2= new Student("Rishabh",2115500018,"O");
            
            if (student1 is Student){
                student1.UpdateGrade("A+"); 
                student1.DisplayStudentDetails();}

            if (student2 is Student){
            student2.DisplayStudentDetails();}
            Student.DisplayTotalStudents();
            // Library lib1 =new Library();
            // lib1.UpdateGrade("E");
            // if(lib1 is Student){
            //     Console.WriteLine("Inside Library");

            // }
            // else{
            //     Console.WriteLine("Not a Student");
            // }
        }
    }
}