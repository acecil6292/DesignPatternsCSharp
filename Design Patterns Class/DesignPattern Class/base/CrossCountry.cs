using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Class
{
   public class CrossCountry : AbstractMountainBike
{
        public CrossCountry()
                   :this(BikeColor.Chrome)
        }

    public CrossCountry(BikeColor color)
        :base(color)

}
