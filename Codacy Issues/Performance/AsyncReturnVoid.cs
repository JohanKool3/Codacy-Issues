using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codacy_Issues.Performance
{
    internal class AsyncReturnVoid
    {

        public async void DoSomethingAsync()
        {
            await Task.Delay(1000);
        }
    }
}
