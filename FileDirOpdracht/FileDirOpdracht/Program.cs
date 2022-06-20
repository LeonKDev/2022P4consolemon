using System;
using System.IO;

namespace Csharp2Opdrachten
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo(@"C:\Users\leonk");
            foreach (FileInfo fi in di.GetFiles())
            {
                Console.WriteLine(fi.Name);
            }
        }
    }
}
