using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCSharp
{
    class TempOrder
    {
        public string CameraID { get; set; }
        public int Price { get; set; }
        public int Quanity { get; set; }
        public TempOrder(string _cameraID,int _price,int _quanity)
        {
            CameraID = _cameraID;
            Price = _price;
            Quanity = _quanity;
        }
    }
}
