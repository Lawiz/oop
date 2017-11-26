using System;
using System.IO;
using System.IO.Compression;
using System.Reflection;


namespace FIles
{
    class Program
    {
        public static DateTime now = DateTime.Now;
        static void Main(string[] args)
        {
           
            string buf = "";
            PASLog pozhar = new PASLog();
            pozhar.EventIO += PASLog.OnEvent;
            Console.WriteLine("Введите строка для записи");
            pozhar.Write(Console.ReadLine());
            Console.WriteLine("Построчныый вывод из файла: " + pozhar.path);
            pozhar.Read(pozhar.path);
            Console.WriteLine("Введите строку для поиска");
            buf = Console.ReadLine();
            Console.WriteLine("Поиск по строке");
            pozhar.Search(buf);
            ///////////////////////////////////////////////////////////
            PASDiskInfo info = new PASDiskInfo();
            info.InfoOfDrivers();
            //////////////////////////
            PASFileInfo fileInfo = new PASFileInfo();
            fileInfo.InfoOfFiles(pozhar.path);
            

            PASFileManager manager = new PASFileManager();

            manager.ListOfFiles();
            manager.Task2();

            manager.Task3(@"C:\", "txt");

            manager.Task4();
            Console.ReadLine();
        }

        class PASLog
        {
            public delegate void del(string m, string path);

            public event del EventIO;




            public string path = @"C:\PASlogfile.txt";

            public void Write(string s)
            {
                string buf = "";
                using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine(s);
                    sw.Close();
                }

                Type type = typeof(PASLog);

                foreach (MethodInfo m in type.GetMethods())
                {
                    if (m.Name == "Write")
                    {
                        buf = m.Name;
                    }
                }

                EventIO(buf, path);
            }


            public void Read(string path)
            {
                string buf = "";

                Type type = typeof(PASLog);

                foreach (MethodInfo m in type.GetMethods())
                {
                    if (m.Name == "Read")
                    {
                        buf = m.Name;
                    }
                }

                EventIO(buf, path);
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }


                    sr.Close();

                }
            }


            public void Search(string search)
            {

                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line == search)
                        {

                            Console.WriteLine("Найдено совпадение " + line);
                            sr.ReadLine();
                            Console.WriteLine(sr.ReadLine());

                        }
                    }


                    sr.Close();

                }

            }

            public static void OnEvent(string m, string path)
            {
                using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default))
                {

                    sw.WriteLine("Пользователь вызвал метод: " + m);
                    sw.WriteLine("Время: " + now);
                }
            }

        }


        class PASDiskInfo
        {
            DriveInfo[] drives = DriveInfo.GetDrives();

            public void InfoOfDrivers()
            {
                foreach (DriveInfo drive in drives)
                {
                    Console.WriteLine("Название: {0}", drive.Name);
                    Console.WriteLine("Тип: {0}", drive.DriveType);
                    if (drive.IsReady)
                    {
                        Console.WriteLine("Объем диска: {0}", drive.TotalSize);
                        Console.WriteLine("Свободное пространство: {0}", drive.TotalFreeSpace);
                        Console.WriteLine("Метка: {0}", drive.VolumeLabel);
                    }
                    Console.WriteLine();
                }
            }

        }


        class PASFileInfo
        {
            public void InfoOfFiles(string path)
            {

                FileInfo fileInf = new FileInfo(path);
                if (fileInf.Exists)
                {
                    Console.WriteLine("Имя файла: {0}", fileInf.Name);
                    Console.WriteLine("Путь : {0}", path);
                    Console.WriteLine("Время создания: {0}", fileInf.CreationTime);
                    Console.WriteLine("Размер: {0}", fileInf.Length);
                }
            }
        }

        class PASFileManager
        {




            public void ListOfFiles()
            {
                string dirName = "C:\\";
                string[] dirs = Directory.GetDirectories(dirName);
                string[] files = Directory.GetFiles(dirName);
                if (Directory.Exists(dirName))
                {
                    Console.WriteLine("Подкаталоги:");

                    foreach (string s in dirs)
                    {
                        Console.WriteLine(s);
                    }
                    Console.WriteLine();
                    Console.WriteLine("Файлы:");

                    foreach (string s in files)
                    {
                        Console.WriteLine(s);
                    }
                }



            }

            public void Task2()
            {
                string dirName = "C:\\";
                string[] dirs = Directory.GetDirectories(dirName);
                string[] files = Directory.GetFiles(dirName);
                DirectoryInfo directory = new DirectoryInfo("C:\\PASInspect");
                directory.Create();

                string path = @"C:\PASInspect\PASdirinfo.txt";

                using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine("Подкаталоги:");

                    foreach (string s in dirs)
                    {
                        sw.WriteLine(s);
                    }
                    sw.WriteLine();
                    sw.WriteLine("Файлы:");

                    foreach (string s in files)
                    {
                        sw.WriteLine(s);
                    }

                    Console.WriteLine("Зaписано");

                }

                string newPath = @"C:\PASInspect\NEWPASdirinfo.txt"; ;
                FileInfo fileInf = new FileInfo(path);
                if (fileInf.Exists)
                {
                    fileInf.CopyTo(newPath, true);
                }
                File.Delete(@"C:\PASInspect\PASdirinfo.txt");


            }

            public void Task3(string dirName, string txt)
            {
                DirectoryInfo directory = new DirectoryInfo("C:\\PASFiles");
                directory.Create();

                string[] files = Directory.GetFiles(dirName, "*." + txt);

                foreach (var s in files)
                {

                    FileInfo fileInf = new FileInfo(s);

                    if (fileInf.ToString() == s)
                    {
                        Console.WriteLine(s);

                        fileInf.CopyTo(@"C:\PASFiles\" + fileInf.Name, true);

                    }
                }

                DirectoryInfo dirInfo = new DirectoryInfo(@"C:\PASInspect");
                dirInfo.Delete(true);
                Directory.Move(@"C:\PASFiles", @"C:\PASInspect\");



            }

            public void Task4()
            {
                string startPath = @"C:\PASInspect";
                string zipPath = @"C:\PASInspect\result.zip";
                string extractPath = @"C:\PASInspect\result";
                /*
                ZipFile.CreateFromDirectory(startPath, zipPath);

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                */
            }
        }
    }
}