using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace klasaInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            

            DirectoryInfo di = new DirectoryInfo(@"C:\");

            Console.WriteLine("\n Podirektoriji: ");

            foreach(DirectoryInfo diinfo in di.GetDirectories())
            {
                Console.WriteLine("{0}\t{1}\t{2}", diinfo.Name, diinfo.CreationTime, diinfo.LastAccessTime);
            }

            foreach(FileInfo fiinfo in di.GetFiles())
            {
                Console.WriteLine("{0}\t{1}\t{2}", fiinfo.Name, fiinfo.CreationTime, fiinfo.LastAccessTime);
            }
            Console.ReadKey();
        }
    }
}
