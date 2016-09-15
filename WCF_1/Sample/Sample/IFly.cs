using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Sample
{
    //定义服务契约
    [ServiceContract]
    public interface IFly
    {
        //操作契约
        [OperationContract]
        string Fly(string name);
    }
}
