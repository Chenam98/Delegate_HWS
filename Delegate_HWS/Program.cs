using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_HWS
{

    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleCalculator sc = new SimpleCalculator();
            AtomicCalculator ac = new AtomicCalculator(sc.NumberGetter, sc.PrintMenu, sc.GetUserChoice, sc.Calculate, sc.PrintResultNicely);
            ac.Run();
        }
    }
}