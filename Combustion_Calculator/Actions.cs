using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combustion_Calculator
{
    internal class Actions
    {
        public static void FormatInputs(Control control)
        {
            control.Text = control.Text.TrimEnd('.');
        }

    }
}
