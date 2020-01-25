using CoreSchool.entities;
using System.Collections.Generic;
using static System.Console;
using System;
using CoreSchool.Util;
using System.Linq;

namespace CoreSchool.App{
    public class SchoolEngine{
        public Schools MySchool{ get; set; }

        public SchoolEngine(){
            //WriteLine("schoolEngine Constructor...");
            Printer.WriteTittle("schoolEngine Constructor...");
        }

        public void __Init__(){
            this.MySchool = new Schools("Pestalozziano", "Eliecer Mulett", 1968, SchoolTypes.Secundary, city:"Corozal");
            //printSchoolCourses(mySchool?.Courses);
            LoadCourses();
            LoadSubjects();
            LoadStudents();
            LoadEvaluations();
        }

        public void LoadCourses(){
            //Colecciones.
            MySchool.Courses = new List<Courses>(){
                new Courses(){ Name = "101", Journey=journeys.Morning },
                new Courses(){ Name = "201", Journey=journeys.Morning },
                new Courses  { Name = "301", Journey=journeys.Morning }
            };    
            MySchool.Courses.Add( new Courses(){  Name = "102", Journey=journeys.Night });
        }

        public void LoadStudents(){
            foreach( var course in MySchool.Courses ){
                course.Students = (SelectStudentsName().ToList());
            }
        }

        public IEnumerable<Student> SelectStudentsName(){
            String[] name     = {"Jose", "Carlos", "Kevin", "Julian", "Ricardo", "Daniel", "Jorge", "Esteban", "Juan", "Luz"};
            String[] lastName = {"Oliva", "Arango", "Bueno", "Jeronimo", "Martin", "Perez", "Marin", "Castillo", "Alba", "Rivera"};

            var studentsList = from Name1 in name
                               from LastName1 in lastName
                               select new Student(){ Name=$"{Name1} {LastName1}"};                      
            return studentsList;
        }

        public void LoadSubjects(){
            foreach( var course in MySchool.Courses){
                var subjectsList = new List<Subject>(){
                    new Subject(){ Name="Math" },
                    new Subject(){ Name="Physical Education"},
                    new Subject(){ Name="Spanish" },
                    new Subject(){ Name="Natural Sciences" }
                };
                course.Subjects?.AddRange(collection: subjectsList);
            }
        }

        public void LoadEvaluations(){

        }

        public void PrintSchoolCourses(List<Courses> schoolCourses){
            Printer.WriteTittle(tittle:"School Courses.");
            if(schoolCourses != null){
                foreach (var course in schoolCourses){
                    Console.WriteLine($"Course Name: {course.Name}, Course Id: {course.UniqueId}, Journey: {course.Journey}");
                }
                //Console.Beep(1000,500);
                Printer.Beep(hz:1000, time:500, repet:3);

            }else{
                //Beep(500, 500);
                Printer.Beep(hz:500, time:500, repet:2);
                return;
            }
            WriteLine("\n");
        }
    }
}