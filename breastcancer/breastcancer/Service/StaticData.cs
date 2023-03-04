using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace breastcancer.Service
{
    //creating static Data from Data
    public class StaticData
    {
        public static Data DataList1 { get; set; }
        static StaticData()
        {
            DataList1 = new Data();
        }
    }
}
