using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phones.Model
{
    public class City
    {
        private int id { get; set; }
        private int provinceId { get; set; }
        private String cityName { get; set; }
        private String cityPrefix { get; set; }
        public City(int id, int provinceId, string cityName, string cityPrefix)
        {
            this.id = id;
            this.provinceId = provinceId;
            this.cityName = cityName;
            this.cityPrefix = cityPrefix;
        }

    }
}
