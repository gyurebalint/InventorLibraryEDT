using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDT_CommonFunctions;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            FileHandling egyAssemblyFile = new FileHandling(@"C:\Users\Gyure Balint\Documents\Vault\Library\Standard TO\Schneider\TO 800A Al 3L\D008780 TO 800A Al 3L.iam");

            Console.WriteLine(egyAssemblyFile.DriveName);
            Console.WriteLine(egyAssemblyFile.ParentFolder);
            Console.WriteLine(egyAssemblyFile.FileName);
            Console.WriteLine(egyAssemblyFile.FileExtension);

        }
    }
}
