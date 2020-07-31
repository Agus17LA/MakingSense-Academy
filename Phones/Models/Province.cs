using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phones.Model
{
    public class Province
    {
        private int id { get; set; }
        private String provinceName { get; set; }
        public Province(int id, string provinceName)
        {
            this.id = id;
            this.provinceName = provinceName;
        }
        
    }
}
