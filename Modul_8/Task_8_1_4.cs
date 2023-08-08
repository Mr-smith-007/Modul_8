using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_8
{
    internal class Task_8_1_4
    {
        class DiscInfo
        {
            public string DiskName { get;}
            public double DiskSpace { get; }
            public double FreeDiscSpace { get; }
            internal DiscInfo (string dname, double dspace, double fdspace)
            {
                DiskName = dname;
                DiskSpace = dspace;
                FreeDiscSpace = fdspace;
            }

        }
    }
}
