using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class ProgrammOut
    {
 public static void Main()
        {

            try
            {
                var appdataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                var pathToFileWithPath = $"{appdataPath}/Lesson12Homework.txt";
                var fileMenager = new FileManager();

                Console.WriteLine("Читаю файл с путем...");
                string pathToCSV = fileMenager.Read(pathToFileWithPath);

                Console.WriteLine("Читаю файл со списком...");
                string filesListRaw = fileMenager.Read(pathToCSV);
                var filesList = filesListRaw;
                foreach (var element in filesList) Console.WriteLine(element);


                fileMenager.Delete(pathToFileWithPath);
                Console.WriteLine("Удалил файл с путем");

            }

            catch (Exception ex) 
            {
                Console.WriteLine("Что-то пошло не так...");
                Console.WriteLine(ex.Message);
            }

        }
   
    }
   
}
