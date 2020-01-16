using System;
using SchoolProy.entities;
using static System.Console;

namespace stageOne{
    class Program{
        static void Main(string[] args){
            var mySchool = new Schools("Pestalozziano", "Eliecer Mulett", 1968, schoolTypes.secundary, city:"Corozal");
            Console.WriteLine(mySchool.ToString());

            mySchool.Courses = new Courses[]{
                new Courses(){ Name = "101" },
                new Courses(){ Name = "201" },
                new Courses  { Name = "301" }
            };
            printSchoolCourses(mySchool?.Courses); // El ? verifica si escuela en efecto existe.
         

            /*
            // Tambien puede ser: Courses[] myCourses = new Courses[] o var myCourses = new Courses[] 
            Courses[] schoolCourses = {
                new Courses(){ Name = "101" },
                new Courses(){ Name = "201" },
                new Courses  { Name = "301" }
            
            };
         
            var schoolCourses = new Courses[3];
            schoolCourses[0] =  new Courses(){
                Name = "101"       
            };
            schoolCourses[1] =  new Courses(){
                Name = "201"       
            };
            schoolCourses[2] =  new Courses(){
                Name = "301"       
            };
            */
        }

        private static void printSchoolCourses(Courses[] schoolCourses){
            WriteLine("**************************************************************************\n\t\t\t   School Courses.");
            if(schoolCourses != null){
                foreach (var course in schoolCourses){
                    Console.WriteLine($"Course Name: {course.Name}, Course Id: {course.UniqueId}");
                }
                Console.Beep(1000,500);
            }else{
                Beep(500, 500);
                return;
            }
        }
    }
}
