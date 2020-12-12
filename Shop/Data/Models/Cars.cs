using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Cars
    {
        public int id { set; get; }
        public string Name { set; get; }
        public string shortdesc { set; get; }
        public string longdesc { set; get; }
        public string img { set; get; }
        public ushort price { set; get; }
        public bool IsFavourite { set; get; }
        public bool available { set; get; }
        public int CategoryId { set; get; }
        public virtual Category Category { set; get; }
    }
}
