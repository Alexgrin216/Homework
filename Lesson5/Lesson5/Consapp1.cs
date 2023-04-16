using Lesson5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    internal class Consapp1
    {
        public static string ArrayToTabs(string[] lines)
        {
            var SB = new System.Text.StringBuilder();
            foreach (var element in lines)
            {
                SB.Append(element);
                SB.Append("\t");
            }
            return SB.ToString();
        }
        public static void Main()
        {
            try
            {

                string? currentPath;
                var fileMenager = new FileManager();

                
                var archivePath = "Archive.zip";
                fileMenager.Unpack(archivePath);
             

            
                currentPath = "Pathetic";
                var info = (fileMenager.Observe(currentPath));
                foreach (var element in info) Console.WriteLine(element);

              
                var filename = "CyberInfo.csv";
                var pathToFile = fileMenager.MakeFile(filename);
                fileMenager.WriteToFile(filename, ArrayToTabs(info));

                fileMenager.Delete(archivePath);
                Console.WriteLine($"Архив {archivePath} удален");

                var appdataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                fileMenager.MakeFile($"{appdataPath}/Lesson12Homework.txt");
                fileMenager.WriteToFile($"{appdataPath}/Lesson12Homework.txt", pathToFile);
                Console.WriteLine($"Создан файл с путем к другому файлу. Ищи его здесь: {Environment.SpecialFolder.ApplicationData}/Lesson12Homework.txt");
            }

            catch (Exception ex)
            {
                Console.WriteLine("Что-то пошло не так...");
                Console.WriteLine(ex.Message);
            }

        }
    }
}


