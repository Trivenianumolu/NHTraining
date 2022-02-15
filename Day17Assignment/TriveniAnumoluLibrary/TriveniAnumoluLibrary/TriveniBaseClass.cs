using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriveniAnumoluLibrary
{
    public class BaseClass
    {
        public int a;
        private int b;
        protected int c;
        internal int d;
        protected internal int e;
        public  void ReadBaseClass()
        {
            a = 1;
            b = 2;
            c = 3;
            d = 4;
            e = 5;   
        }
    }
    public class DerivedClass:BaseClass
    {
        public void ReadDerivedClass()
        {
            a = 1;
            b = 2;
            c = 3;
            d = 4;
            e = 5;


        }
    }
    public class OtherClass
    {
        public void ReadOtherClass()
        {
            BaseClass bc = new BaseClass();
            bc.a = 1;
            bc.b = 2;
            bc.c = 3;
            bc.d = 4;
            bc.e = 5;
        }
    }


}
