using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{

    class Demo
    {
        int mdata;
        public Demo()
        {
            mdata = 45;
        }
        public Demo(int mdata)
        {

            this.mdata = mdata;
        }
        public void show()
        {
            Console.WriteLine(mdata);
        }
    }
    class Test
    {
        static void Main()
        {
            Demo x = new Demo();
            x.show();
            Demo y = new Demo(44);
            y.show();
            Console.ReadLine();
        }

    }
}