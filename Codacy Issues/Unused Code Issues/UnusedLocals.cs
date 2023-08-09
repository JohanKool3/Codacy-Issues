using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codacy_Issues.Code_Style_Issues
{
    internal class UnusedLocals
    {

        public int DoSomeSpecialCheckCase(int number1, int number2)
        {
            try
            {
                return number1 / number2;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void RunApplication()
        {

            int index = 0;
            var _ = DoSomeSpecialCheckCase(10,0);

            Console.WriteLine("Currently Running Application");
        }
    }
}
