using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Update
    {
        public void Upd(string t)
        {

            if (t == "U")
            {
                Class1 uFile = new Class1();
                uFile.FileOper();
                StreamWriter uw = new StreamWriter(@"C:\C#_file\sw2.txt", false, Encoding.Default);

                Console.Write("Укажите номер задачи которую хотите редактировать:");
                uFile.Check();
                uFile.arr[uFile.temp - 1] = Console.ReadLine();

                foreach (string p in uFile.arr)
                {
                    uw.WriteLine(p);
                }
                uw.Close();

            }
        }
    }
}
