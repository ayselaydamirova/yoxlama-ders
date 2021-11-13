
using System;
using System.Threading;

namespace yoxlama_ders
{
    class Program
    {
        static void Main(string[] args)

        {
           Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB")

            string path = @"C:\Users\Айсел\Documents";


            DerectoryInfo dirInfo = new DerectoryInfo(path);

            Console.WriteLine(dirInfo.Exists);
            Console.WriteLine(dirInfo.Name);
            Console.WriteLine(dirInfo.FullName);
            Console.WriteLine(dirInfo.CreatioanTime);
            Console.WriteLine(dirInfo.LastAccessTime);
            Console.WriteLine(dirInfo.LastWriteTime);
        }
        
    }
}
