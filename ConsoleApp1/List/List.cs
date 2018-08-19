using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Threading;

namespace ConsoleApp1
{
    class List
    {
        public void Li()
        {
            
            Console.WriteLine("Список задач: \n");

            using (StreamWriter sw = new StreamWriter(@"C:\C#_file\sw2.txt", true, Encoding.Default))
            {

            }

            using (StreamReader sr = new StreamReader(@"C:\C#_file\sw2.txt", Encoding.Default))
            {
                ArrayList mas = new ArrayList();
                string line;
                int count = 1;
                
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine($"  {count}.{line}");
                    count++;

                }
                
            }
        }
    }
}
