using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceWCF
{
    public class Seller : ISeller
    {
        HangYe_StudyEntities db = new HangYe_StudyEntities();

        public bool AddUser(Model.User user, out int userID)
        {
            throw new NotImplementedException();
        }

        public bool AddShop(Model.Shop shop, out int shopID)
        {
            throw new NotImplementedException();
        }

        public bool Add(Model.User user, Model.Shop shop)
        {
            return false;
        }
    }
}
