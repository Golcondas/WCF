using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    public class People:IFly
    {

        public string Fly(string name)
        {
            return name +" can fly!!!!!!";
        }
    }
}
