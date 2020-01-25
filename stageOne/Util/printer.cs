using System;

namespace CoreSchool.Util{
    public static class Printer{
        public static void DrawLine(int size = 74){
            var line = "".PadLeft(size, '*');
            Console.WriteLine(line);
        }

        public static void WriteTittle(String tittle="tittle", int size=90){
            DrawLine(size:size);
            Console.WriteLine($"\t\t\t     {tittle}\n");
        }

        public static void Beep(int hz=500, int time=200, int repet=1){
            for(int i = 0; i < repet; i++){
                Console.Beep(hz, time);
            }
        }
    }
}