using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codacy_Issues.Code_Style_Issues
{
    public class RemoveInstanceData
    {

        public int index = 0;
        public bool isValue = false;

        public RemoveInstanceData(int index, bool isValue)
        {
            this.index = index;
            this.isValue = isValue;
        }
    }
}
