using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriveniAnumoluLibrary;

namespace PublicLibrary
{
    public class PublicBaseClass:BaseClass
    {
        
            public void ReadClass()
            {
                a = 1;
                b = 2;
                c = 3;
                d = 4;
                e = 5;
            }
        
    }
    public class Other
    {

        public void ReadData()
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
