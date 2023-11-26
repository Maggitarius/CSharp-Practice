using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Practice7
{

    internal class Explorer
    {
        public static void vivodpapok()
        {
                DriveInfo[] drives = DriveInfo.GetDrives();
                for (int i = 0; i < drives.Length; i++)
                {
                    long a = drives[i].TotalFreeSpace;
                    long b = drives[i].TotalSize;
                    string c = drives[i].Name;
                    Console.WriteLine($"  {c}: Свободно {(a / 1024) / 1024 / 1024} ГБ из {(b / 1024) / 1024 / 1024} ГБ");
                }
                int diskindex = menu.Show(4, drives.Length + 2);
                if (diskindex == -1)
                {
                    Environment.Exit(0);
                }
                DriveInfo disk = drives[diskindex - 2];
                Console.Clear();
                Console.SetCursorPosition(50, 0);
                Console.WriteLine($"Выбранный диск: {disk.Name}");
                Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("\tНазвание файла: \t\t\t    Дата создания:");
                papki(disk.Name);
        }

        public static void papki(string drive)
        {
            Console.Clear();
            string[] folders = Directory.GetFileSystemEntries(drive);
            int i = 3;
            string papkapath = "";
            Console.WriteLine("\t\t\t\t\tДиск C:");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("  Название Папки \t\t\t\t   Дата Создания Папки");
            Console.Write("");
            foreach (string folder in folders)
            {
                string papkaname = Path.GetFileName(folder);
                DateTime datapapka = Directory.GetCreationTime(folder);
                Console.WriteLine($"  {papkaname}");
                Console.SetCursorPosition(50, i);
                Console.WriteLine($" {datapapka}");
                papkapath = Path.Combine(drive, papkaname);
                i++;
            }
            int strelka = menu.Show(3, folders.Length + 2);
            if (strelka == -1)
            {
                Console.Clear();
                return;
            }
            papki(folders[strelka - 3]);
            otkroimnefile(drive);
        }
        static public void otkroimnefile(string drive)
        {
            Process.Start(new ProcessStartInfo { FileName = drive, UseShellExecute = true });
        }
    }
}
 