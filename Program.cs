using System;
using System.Collections.Generic;

namespace SingletonUniversity
{
    class Program
    {
        static void Main(string[] args)
        {
           Database db = Database.GetInstance();
          Database db2 = Database.GetInstance();
            Console.WriteLine("Hello World!");
            System.Console.WriteLine(db.Guid); 
            System.Console.WriteLine(db2.Guid);

            //Database2 db2 = new Database2();
           //List<Student> Students = new List<Student>();
            //List<Subject> Subjects = new List<Subject>();
            //List<Teacher> Teachers= new List<Teacher>();
            //db2.Students = new List<Student>();
            db.Students = new List<Student>();
          
            db.Teachers = new List<Teacher>();
            db.Subjects = new List<Subject>();
            
            db.Students.Add(new Student() { Name = "Alex", Subjects2=new List<string> {"Math", "Programming" } }) ;
            db.Students.Add(new Student(){ Name = "Boris", Subjects2 = new List<string> { "Math", "Physics" } });
            db.Students.Add(new Student(){ Name = "Cimon" , Subjects2 = new List<string> { "Physics", "Programming" } });

            db.Teachers.Add(new Teacher() { Name = "Peter", Subjects2 = new List<string> { "Math"} });
            db.Teachers.Add(new Teacher() { Name = "Allex" , Subjects2 = new List<string> { "Programming" } });
            db.Teachers.Add(new Teacher() { Name = "Simone", Subjects2 = new List<string> {  "Physics" } });

            db.Subjects.Add(new Subject() { Name = "Math", Teacher2=new List<string> { "Peter"} });
            db.Subjects.Add(new Subject() { Name = "Physics", Teacher2 = new List<string> { "Rob" } });
            db.Subjects.Add(new Subject() { Name = "Programming" , Teacher2 = new List<string> { "Simone" } });

            

            for (int i = 0; i < db.Students.Count; i++)
            { 
                Console.WriteLine(db.Students[i].Subjects2);
               //Console.WriteLine(db.Subjects[i].Name);
            //Console.WriteLine(db.Teachers[i].Subjects2);
            }
        }
    }
}
