

using System.IO.Compression;

namespace Lesson5
{
    public class FileManager
    {
        public string Unpack(string? path, string? destinationPath = null) 
        {
            if (destinationPath == null) destinationPath = Directory.GetCurrentDirectory();
            if (path == null) throw (new Exception("Путь не указан!"));


            if (path.Contains(".zip"))
            {
                try
                {
                    ZipFile.ExtractToDirectory(path, destinationPath);
                    return "Архив распакован";
                }

                catch
                {
                    throw (new Exception($"Невозможно распаковать архив {path}"));
                   
                }
            }
            else
            {
                throw (new Exception("Формат архива не поддерживается или путь указан неверно"));
            }
        }

        public string Read(string? path)
        {
         if (path == null) throw (new Exception("Путь не указан!"));
            

        if (File.Exists(path)) return File.ReadAllText(path);

            else throw (new Exception($"Невозможно прочитать данные из файла {path}"));
        }

        public string[] Observe(string? path)
        {
            if (path == null) throw (new Exception("Путь не указан!"));

            try
            {
                List<string> result = new List<string>();

                string[] dirList = Directory.GetDirectories(path);
                for (int i = 0; i < dirList.Length; ++i)
                {
                    dirList[i] += "\t" + Directory.GetLastWriteTime(dirList[i]);
   
                dirList[i] += "\tПапка";
                }
                result.AddRange(dirList);

                string[] filesList = Directory.GetFiles(path);
                for (int i = 0; i < filesList.Length; ++i)
                {
                    filesList[i] += "\t" + File.GetLastWriteTime(filesList[i]);
                    filesList[i] += "\tФайл";
                }
                result.AddRange(filesList);


                return result.ToArray();
            }

            catch
            {
                throw (new Exception($"Невозможно посмотреть содержимое {path}"));
            }
        }

        public string MakeFile(string? path)
        {
            if (path == null) throw (new Exception("Путь не указан!"));

            try
            {
                var currentFile = File.Create(path);
                currentFile.Close();
                return Path.GetFullPath(path);
            }

            catch
            {
                throw (new Exception($"Невозможно создать файл {path}"));
            }
        }

        public void WriteToFile(string? path, string data)
        {
            if (path == null) throw (new Exception("Путь не указан!"));

            if (File.Exists(path)) File.WriteAllText(path, data);

            else throw (new Exception($"Запись в несуществующий файл {path}"));
        }

        public void Delete(string? path)
        {
            if (path == null) throw (new Exception("Путь не указан!"));

            if (File.Exists(path)) File.Delete(path);

            else throw (new Exception($"Файл {path} и так не существует!"));
        }

    }
}
