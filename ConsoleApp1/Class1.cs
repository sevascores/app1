using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ConsoleApp1
{
    class Class1
    {
        public string line1;
        public ArrayList arr = new ArrayList();
        public int temp;
        
        //добавление данных в массив из файла
        public void FileOper()
        {

            StreamReader ur = new StreamReader(@"C:\C#_file\sw2.txt", Encoding.Default);
            
            while ((line1 = ur.ReadLine()) != null)
            {
                arr.Add(line1);
            }

            ur.Close();
        }

        //Проверка на корректность веденных данных
        public void Check()
        {
            string ind = Console.ReadLine();
            bool res = Int32.TryParse(ind, out temp);
            
            while (!res || (arr.Count < temp || temp <= 0))
            {
                if (!res)
                {
                    Console.Write("Ваше значение не число! Введите число:");
                    ind = Console.ReadLine();
                    res = Int32.TryParse(ind, out temp);
                }

                if ((arr.Count < temp || temp <= 0))
                {
                    Console.WriteLine("Под этим номером задача отсутсвует!");
                    Console.Write("Введите число:");
                    ind = Console.ReadLine();
                    res = Int32.TryParse(ind, out temp);
                }

            }
        }
    }
}
