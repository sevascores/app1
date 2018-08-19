using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Del
    {
        public void Delete(string t)
        {
           
            if (t == "D")
            {

                Class1 dFile = new Class1();
                dFile.FileOper();
                StreamWriter uw = new StreamWriter(@"C:\C#_file\sw2.txt", false, Encoding.Default);

                Console.Write("Укажите номер задачи которую хотите удалить: ");
                dFile.Check();
                dFile.arr.RemoveAt(dFile.temp - 1);
            
                foreach (string p in dFile.arr)
                {
                    uw.WriteLine(p);
                }

                uw.Close();

            }
            
        }
    }
}
