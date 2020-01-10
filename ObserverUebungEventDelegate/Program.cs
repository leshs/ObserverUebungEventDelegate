using System;

namespace ObserverUebungEventDelegate
{
    class Program
    {
        Logger logger1 = new Logger(Console.Out);
        Logger logger2 = new Logger("C:\\Users\\...\\Documents\\report.txt");
        private FolderWatch folderWatch = new FolderWatch("C:\\Users\\...\\Documents\\TestFolder");

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run(); 
        }

        public void Run()
        {
            folderWatch.FileAddedEvent += this.FileAddedHandler;

            //Test
            while (true)
            {
                string file = Console.ReadLine();
                folderWatch.FileAdded(file);
            }   
        }

        public void FileAddedHandler(string file)
        {
            logger1.WriteLine(file);
            logger2.WriteLine(file);
        }
    }
}
