using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace breastcancer
{
    internal class Data
    {
        public int ImageId { get; set; }
        public String ImageName { get; set; }
        public int Diagnosis { get; set; }

        public String? Comment { get; set; }
        public int DoctorId { get; set; }
    }
}
