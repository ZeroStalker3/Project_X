using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите путь к папке с фотографиями:");
            string folderPath = Console.ReadLine();

            Console.WriteLine("Выберите период сортировки (день, неделя, месяц):");
            string period = Console.ReadLine().ToLower();

            if (Directory.Exists(folderPath))
            {
                RemoveDuplicates(folderPath);
                SortFilesByPeriod(folderPath, period);
                Console.WriteLine("Операция завершена.");
            }
            else
            {
                Console.WriteLine("Указанная папка не существует.");
            }
        }

        static void RemoveDuplicates(string folderPath)
        {
            var files = Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories);
            var fileGroups = files.GroupBy(f => new FileInfo(f).Length)
                                  .SelectMany(g => g.GroupBy(f => Path.GetFileName(f)));

            foreach (var group in fileGroups)
            {
                var duplicates = group.Skip(1).ToList();
                foreach (var duplicate in duplicates)
                {
                    File.Delete(duplicate);
                    Console.WriteLine($"Удален дубликат: {duplicate}");
                }
            }
        }

        static void SortFilesByPeriod(string folderPath, string period)
        {
            var files = Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                DateTime creationDate = File.GetCreationTime(file);
                string targetFolder = GetTargetFolder(folderPath, creationDate, period);
                Directory.CreateDirectory(targetFolder);
                string targetPath = Path.Combine(targetFolder, Path.GetFileName(file));
                File.Move(file, targetPath);
                Console.WriteLine($"Файл перемещен: {file} -> {targetPath}");
            }
        }

        static string GetTargetFolder(string rootPath, DateTime date, string period)
        {
            string folderName = "";
            switch (period)
            {
                case "день":
                    folderName = date.ToString("yyyy-MM-dd");
                    break;
                case "неделя":
                    DateTime startOfWeek = date.AddDays(-(int)date.DayOfWeek);
                    DateTime endOfWeek = startOfWeek.AddDays(6);
                    folderName = $"{startOfWeek:yyyy-MM-dd}_to_{endOfWeek:yyyy-MM-dd}";
                    break;
                case "месяц":
                    folderName = date.ToString("yyyy-MM");
                    break;
                default:
                    throw new ArgumentException("Недопустимый период сортировки");
            }
            return Path.Combine(rootPath, folderName);
        }
    }
}
