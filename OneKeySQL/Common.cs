using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneKeySQL
{
    class Common
    {
        internal static void printSql(TextBox a,String s)
        {
            a.Text += s.Replace("\t", "");
        }
    }
}
