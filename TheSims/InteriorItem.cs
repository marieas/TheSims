using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSims
{
    public class InteriorItem
    {
        public string FurnitureName { get; private set; }
        public InteriorItem(string furnitureName)
        {
            FurnitureName = furnitureName;
        }
    }
}
