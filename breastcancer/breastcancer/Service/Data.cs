using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace breastcancer
{
    public class Data
    {
        public int ImageId { get; set; }
        public String ImageName { get; set; }
        public int Diagnosis { get; set; }
        public int RectX1 { get; set; }
        public int RectX2 { get; set; }
        public int RectY1 { get; set; }
        public int RectY2 { get; set; }
        public String? Comment { get; set; }
        public int DoctorId { get; set; }
    }
}
