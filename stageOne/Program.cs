using System;
using SchoolProy.entities;

namespace stageOne{
    class Program{
        static void Main(string[] args){
            var mySchool = new Schools("Pestalozziano", "Eliecer Mulett");
            Console.WriteLine("Colegio: "+ mySchool.Name +", CEO: " +mySchool.Ceo);
        }
    }
}
