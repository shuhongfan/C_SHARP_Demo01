using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex5_9
{
    public delegate void CalculateEventHandler(object sender, EventArgs e);
    class CalculateWithEvent
    {
        public event CalculateEventHandler Calculate;
        protected virtual void OnCalculate(EventArgs e)
        {
            if (Calculate != null)
            {
                Calculate(this, e);
            }
        }

            public int Add(int a, int b)
        {
            OnCalculate(EventArgs.Empty);
            return a + b;
        }
        public int Sub(int a, int b)

        {
            OnCalculate(EventArgs.Empty);
            return a - b;
        }
    }
    class EventListener
    {
        private CalculateWithEvent CalculateCase;
        public EventListener(CalculateWithEvent calculateCase)
        {
            CalculateCase = calculateCase;
            CalculateCase.Calculate += new CalculateEventHandler(CalculateCase_Calculate);
        }
        void CalculateCase_Calculate(object sender, EventArgs e)
        {
            Console.WriteLine("运算事件被调用!");
        }
    }

    class Test
    {
        static void Main(string[] args)
        {
            CalculateWithEvent myCalculate = new CalculateWithEvent();
            EventListener myListener = new EventListener(myCalculate);
            myCalculate.Add(2, 3);
            myCalculate.Sub(3, 2);
            Console.Read();

        }
    }
}
