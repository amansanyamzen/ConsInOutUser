using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ConsInOutUser
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter the Content : ");
            string str = Console.ReadLine();
            using (FileStream f1 = new FileStream(@"D:f11.txt", FileMode.Create, FileAccess.Write))
            {
                using(StreamWriter sw= new StreamWriter(f1))
                {
                    sw.WriteLine(str);
                }
            }
            using(FileStream fr1 = new FileStream(@"D:f11.txt", FileMode.Open))
            {
                using(StreamReader sr = new StreamReader(fr1))
                {
                    Console.WriteLine($"Contents of file are : {sr.ReadToEnd()}");
                }
            }



              Console.ReadLine();






        }
    }
}
