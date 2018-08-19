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
    class Program
    {
     
        static void Main(string[] args)
        {
            while (true)
            {   // Создание папки на диске для хранения файла
                Path path = new Path();
                path.DirPath();

                // Ссоздание файла в папке и выведенние списка задач
                List list = new List();
                list.Li();


                Console.WriteLine(" ");

                // Создание навигации по действиям
                Navig navig = new Navig();
                navig.Nav();

                // Добавление задачи в список
                Add add = new Add();
                add.Add1(navig.t);

                // Обновление пунктов задач
                Update update = new Update();
                update.Upd(navig.t);

                // Удаление пунктов задач
                Del del = new Del();
                del.Delete(navig.t);

                Thread.Sleep(1000);
                Console.Clear();
            }
            
          
        }
    }
   
}
