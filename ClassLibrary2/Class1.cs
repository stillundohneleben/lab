using System;

namespace ClassLibrary2
{
    public class Class1
    {
        private string x;
        public Class1(string x)
        {
            this.x = x;
        }

        public string getClass1()
        {
            return "" + Math.Sin(double.Parse(x) * Math.PI / 180);

        }
    }
}
