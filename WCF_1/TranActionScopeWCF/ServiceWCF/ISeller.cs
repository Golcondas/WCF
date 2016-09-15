using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiceWCF
{
    [ServiceContract]
    public interface ISeller
    {
        [OperationContract(Name = "AddUser")]
        bool AddUser(Model.User user, out int userID);

        [OperationContract(Name="AddShop")]
        bool AddShop(Model.Shop shop, out int shopID);

        [OperationContract(Name="我不知道，以后试试吧")]
        bool Add(Model.User user,Model.Shop shop);

    }
}
