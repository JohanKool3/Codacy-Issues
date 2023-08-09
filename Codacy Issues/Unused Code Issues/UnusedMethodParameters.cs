using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codacy_Issues.Unused_Code_Issues
{
    internal class UnusedMethodParameters
    {
        private void DoSomething(int a, int b, int c)
        {
            Console.WriteLine(a + b);
        }

        public void RunApplication(int a, int b, int c)
        {
            Console.WriteLine("Currently Running Application");
            Console.WriteLine(a + b);
        }
    }
}
