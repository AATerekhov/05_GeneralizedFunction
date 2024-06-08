using _05_GeneralizedFunction.FileFound;

namespace _05_GeneralizedFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Путь к папке с файлами.
            string path = "C:\\Users\\User\\Desktop\\test";
            var fileFiundler = new FileFoundler(path);
            fileFiundler.FileFound += FileFiundler_FileFound;
            fileFiundler.StartFound();//Запуск поиска файлов в папке.
        }

        private static void FileFiundler_FileFound(object? sender, EventArgs e)
        {
            if (sender is FileFoundler foundler)
            {
                if (e is FileArgs fileArgs)//вывод информации о файле.
                {
                    if (fileArgs.FileName == foundler.MaxPathString)
                        Console.WriteLine("Это максимальный файл!");
                    Console.WriteLine(fileArgs.FileName);
                }
                Console.WriteLine("Для отсановки введите [S]");
                if (Console.ReadLine() == "S")
                {
                    foundler.Continuation = false;
                }
            }           
        }
    }
}
