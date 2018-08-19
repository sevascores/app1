using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Navig
    {
        public string t;
        public void Nav()
        {
            Console.WriteLine("Для добавления задачи нажмите латинскую 'A'");
            Console.WriteLine("Для редактирования задачи нажмите латинскую 'U'");
            Console.WriteLine("Для удаления задачи нажмите латинскую 'D'");
            Console.Write("Ввод: ");

            t = Console.ReadLine().ToUpper();
            while (t != "A" && t != "U" && t != "D")
            {
                Console.WriteLine("Введите другое значение 'A','U'или 'D'");
                t = Console.ReadLine().ToUpper();
            }
        }
    }
}
