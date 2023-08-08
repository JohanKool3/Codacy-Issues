using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codacy_Issues.Code_Style_Issues
{
    internal class SwitchToIf
    {

        public int Value { get; set; }

        public SwitchToIf(int value)
        {
            Value = value;
        }


        public void ChangeValue(int valueIn)
        {
            switch (valueIn)
            {
                case 0:
                    // Invalid value for this Attribute as must not be 0
                    Value = 1;
                    break;

                default:
                    Value = valueIn;
                    break;
            }

        }
    }
}
