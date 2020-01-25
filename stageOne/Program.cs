using System;
using CoreSchool.entities;
using CoreSchool.App;
using System.Collections.Generic;
using static System.Console;

namespace CoreSchool{
    class Program{
        static void Main(string[] args){
            var myEngine = new SchoolEngine();
            myEngine.__Init__();
            myEngine.PrintSchoolCourses(myEngine?.MySchool?.Courses);
        }

        private static bool Predicate(Courses obj){
            return obj.Name == "301";
        }
    }
}
