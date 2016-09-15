using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayPlane
{
    public class SingleObject
    {
        //单例设计模式
        //1.单例私有化
        private SingleObject() { }
        //2. 声明全局唯一对象
        private static SingleObject _single = null;
        //3. 提供一个静态函数，用来返回一个唯一的静态对象

    }
}
