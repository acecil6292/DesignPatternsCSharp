using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Class
{
    public class DownHill : AbstractMountainBike
        {

        public DownHill()
            : this(BikeColor.Chrome)
        }

    public DownHill(BikeColor color)
        : base(color)

}
