using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_HWS
{
    public class AtomicCalculator
    {
        //Fields
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Option { get; set; }
        public double Result { get; set; }

        public Func<int> GetNumberFromUser { get; set; }
        public Action MenuPrinter { get; set; }
        public Func<int> GetUserChoice { get; set; }
        public Func<int, int, int, double> Calculate { get; set; }
        public Action<int, int, int, double> ResultPrinter { get; set; }


        //ctor
        public AtomicCalculator(Func<int> getNumberFromUser, Action menuPrinter, Func<int> getUserChoice,
                                Func<int, int, int, double> calculate, Action<int, int, int, double> resultPrinter)
        {
            GetNumberFromUser += getNumberFromUser;
            MenuPrinter += menuPrinter;
            GetUserChoice += getUserChoice;
            Calculate += calculate;
            ResultPrinter += resultPrinter;
        }


        //methods
        public void Run()
        {
            int x = GetNumberFromUser();
            int y = GetNumberFromUser();
            MenuPrinter();
            int Option = GetUserChoice();
            double Result = Calculate(x, y, Option);
            ResultPrinter(x, y, Option, Result);
        }

    }

}
