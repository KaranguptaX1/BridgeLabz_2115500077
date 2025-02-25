    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    class Program{
        static void Main(string[] args){
            string merged = "merged.csv";
            var students1 = ReadStudents<Student1>("students1.csv", values => new Student1{ID = int.Parse(values[0]), Name = values[1], Age = int.Parse(values[2]) });
            var students2 = ReadStudents<Student2>("students2.csv", values => new Student2 { ID = int.Parse(values[0]), Marks = int.Parse(values[1]), Grade = values[2] });
            WriteMergedStudents(MergeStudents(students1, students2), merged);
            Console.WriteLine("Merged data has been written to " + merged);
        }
        static List<T> ReadStudents<T>(string filePath, Func<string[], T> mapFunc){
            return File.ReadLines(filePath).Skip(1).Select(line => mapFunc(line.Split(','))).ToList();
        }
        static List<MergedStudent> MergeStudents(List<Student1> students1, List<Student2> students2){
            var students2Dict = students2.ToDictionary(s => s.ID);
            return students1.Where(s1 => students2Dict.ContainsKey(s1.ID)).Select(s1 => new MergedStudent{
                ID = s1.ID,
                Name = s1.Name,
                Age = s1.Age,
                Marks = students2Dict[s1.ID].Marks,
                Grade = students2Dict[s1.ID].Grade
            }).ToList();
        }
        static void WriteMergedStudents(List<MergedStudent> students, string filePath){
            File.WriteAllLines(filePath, new[] { "ID,Name,Age,Marks,Grade" }.Concat(students.Select(s => $"{s.ID},{s.Name},{s.Age},{s.Marks},{s.Grade}")));
        }
    }
    class Student1{ 
        public int ID; 
        public string Name; 
        public int Age;
        }
    class Student2{
        public int ID; 
        public int Marks; 
        public string Grade; 
        }
    class MergedStudent{ 
        public int ID; 
        public string Name; 
        public int Age;
        public int Marks; 
        public string Grade; 
        }
