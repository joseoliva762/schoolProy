// using System;
// using SchoolProy.entities;
// using System.Collections.Generic;
// using static System.Console;

// namespace stageOne{
//     class comentarios{
//         static void Main(string[] args){
//             var mySchool = new Schools("Pestalozziano", "Eliecer Mulett", 1968, schoolTypes.secundary, city:"Corozal");
//             Console.WriteLine(mySchool.ToString());
            
            
//             Colecciones.
//             mySchool.Courses = new List<Courses>(){
//                 new Courses(){ Name = "101", Journey=journeys.morning },
//                 new Courses(){ Name = "201", Journey=journeys.morning },
//                 new Courses  { Name = "301", Journey=journeys.morning }
//             };    
//             mySchool.Courses.Add( new Courses(){  Name = "102", Journey=journeys.night });
//             printSchoolCourses(mySchool?.Courses);
            
//             //Predicate<Courses> myAlgorithm = predicate;
//             mySchool.Courses.RemoveAll(predicate);
//             printSchoolCourses(mySchool?.Courses);

//             // Ahora lo hacemos con expresiones lambda
//             mySchool.Courses.RemoveAll( delegate(Courses Cs){
//                  return Cs.Name == "201";
//             }); 
//             Lambda
//             mySchool.Courses.RemoveAll((Courses Cs) => Cs.Name == "102");

//             printSchoolCourses(mySchool?.Courses);


//             /*
//             var extraCourses = new List<Courses>(){
//                 new Courses(){ Name = "401", Journey=journeys.morning },
//                 new Courses(){ Name = "501", Journey=journeys.morning },
//                 new Courses  { Name = "202", Journey=journeys.night }
//             };
//             mySchool.Courses.AddRange(extraCourses);
//              */
//         /*
//             Arreglos
//             mySchool.Courses = new Courses[]{
//                 new Courses(){ Name = "101" },
//                 new Courses(){ Name = "201" },
//                 new Courses  { Name = "301" }
//             };
//         */


//               mySchool.Courses = new Courses[]{
//                new Courses{ Name = "Funcionó" }
//             };

//          /*   
//             printSchoolCourses(mySchool?.Courses); // El ? verifica si escuela en efecto existe.
//             extraCourses.Clear(); //Para borrar toda la coleccion.
//             printSchoolCourses(extraCourses);


//             Para el ejemplo
//             Courses tmp = new Courses(){ Name="101-Vacacional", Journey=journeys.holiday };
//             mySchool.Courses.Add(tmp);
//             printSchoolCourses(mySchool?.Courses);
//             WriteLine("Course.hash:"+ tmp.GetHashCode());
//             mySchool.Courses.Remove(tmp);
//             printSchoolCourses(mySchool?.Courses);
//             */
//             /*
//             Tambien puede ser: Courses[] myCourses = new Courses[] o var myCourses = new Courses[] 
//             Courses[] schoolCourses = {
//                 new Courses(){ Name = "101" },
//                 new Courses(){ Name = "201" },
//                 new Courses  { Name = "301" }
            
//             };
         
//             var schoolCourses = new Courses[3];
//             schoolCourses[0] =  new Courses(){
//                 Name = "101"       
//             };
//             schoolCourses[1] =  new Courses(){
//                 Name = "201"       
//             };
//             schoolCourses[2] =  new Courses(){
//                 Name = "301"       
//             };
//             */
//         }

//         private static bool predicate(Courses obj){
//             return obj.Name == "301";
//         }
//         private static void printSchoolCourses(List<Courses> schoolCourses){
//             WriteLine("**************************************************************************\n\t\t\t   School Courses.");
//             if(schoolCourses != null){
//                 foreach (var course in schoolCourses){
//                     Console.WriteLine($"Course Name: {course.Name}, Course Id: {course.UniqueId}, Journey: {course.Journey}");
//                 }
//                 Console.Beep(1000,500);
//             }else{
//                 Beep(500, 500);
//                 return;
//             }
//             WriteLine("\n");
//         }
//     }
// }
