using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
interface I1
    {
        void Get();
        void Put();
    }
    interface I2
    {
        void Get();
        void Pu1();
    }
    class A : I1, I2
    {
        void I1.Get()
        {
            
        }

        void I2.Get()
        {
         
        }

        void I2.Pu1()
        {
            throw new NotImplementedException();
        }

        void I1.Put()
        {
            throw new NotImplementedException();
        }
    }
    class MultipleInterfaces
    {
    }
}
