using System;
using SchoolProy.entities;

namespace stageOne{
    class Program{
        static void Main(string[] args){
            var mySchool = new Schools("Pestalozziano", "Eliecer Mulett", 1968, schoolTypes.secundary, city:"Corozal");
            Console.WriteLine(mySchool.ToString());
            
            var schoolCourses = new Courses[3];


            schoolCourses[0] = new Courses(){
                Name = "101"       
            };
            schoolCourses[1] = new Courses(){
                Name = "201"       
            };
            schoolCourses[2] = new Courses(){
                Name = "301"       
            };
            
            printSchoolCourses(schoolCourses);


        }

        private static void printSchoolCourses(Courses[] schoolCourses){
            System.Console.WriteLine("**************************************************************************");
            foreach (var course in schoolCourses){
                  Console.WriteLine($"Course Name: {course.Name}, Course Id: {course.UniqueId}");
            }
            Console.Beep(1000,500);
        }
    }
}
