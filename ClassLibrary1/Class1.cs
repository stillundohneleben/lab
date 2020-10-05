using System;

namespace ClassLibrary1
{
    public class Class2
    {
        private string x, y;
        public Class2(string x, string y)
        {
            this.x = x;
            this.y = y;
        }

        public string getClass2()
        {
            return "" + Int32.Parse(x) * Int32.Parse(y);

        }
    }
}
