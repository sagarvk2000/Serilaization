using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serilaization
{
    //in c# it is called attributes
    [Serializable] //to allow class to be serialized
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int  Price { get; set; }
    }
}
