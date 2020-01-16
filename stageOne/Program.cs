using System;
using SchoolProy.entities;

namespace stageOne{
    class Program{
        static void Main(string[] args){
            var mySchool = new Schools("Pestalozziano", "Eliecer Mulett", 1968, schoolTypes.Secundary, city:"Corozal");
            Console.WriteLine(mySchool.ToString());

        }
    }
}
