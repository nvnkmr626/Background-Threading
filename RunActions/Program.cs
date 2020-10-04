using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunActions
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassRunActions runActions = new ClassRunActions();
            runActions.Run();
            Console.WriteLine("\nStart Running Actions.");
            Console.ReadKey();
        }
    }
}
