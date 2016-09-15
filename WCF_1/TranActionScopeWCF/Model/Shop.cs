using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Runtime.Serialization;

namespace Model
{
    [DataContract]
    public class Shop
    {
        [DataMember]
        public int ShopID { get; set; }

        [DataMember]
        public int UserID { get; set; }

        [DataMember]
        public string ShopName { get; set; }

        [DataMember]
        public string ShopUrl { get; set; }

    }
}
