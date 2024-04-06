using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelliCode.MAUI.Functions;

internal class AnotherStringTest
{
    internal string Add9(string a9, string b9)
    { return a9 + b9; }
    internal string Add10(string a10, string b10)
    { return a10 + b10; }
    internal string Add11(string a11, string b11)
    { return a11 + b11; }
    internal string Add12(int a12, int b12)
    { return a12.ToString() + b12.ToString(); }
    internal string Add13(string a13, string b13)
    { return string.Format("{0}{1}", a13, b13); }
    internal string Add14(string a14)
    { return a14 + "foo"; }
    internal string Add15(string a15, string b15)
    { return a15 + b15 + "bar"; }
}
