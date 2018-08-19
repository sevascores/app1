using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Add
    {
        public void Add1(string t)
        {
            if (t == "A")
            {

                Console.Write("Добавьте Задачу!: ");
                using (StreamWriter sw1 = new StreamWriter(@"C:\C#_file\sw2.txt", true, Encoding.Default))
                {

                    string add = Console.ReadLine();
                    while (add != "upd")
                    {
                        sw1.WriteLine(add);
                        Console.Write("Добавьте новую задачу и нажмите клавишу 'Enter', или обновите список (ввести 'upd'): ");
                        add = Console.ReadLine();
                        
                    }

                }

            }
        }
           
     }               


}
                
      