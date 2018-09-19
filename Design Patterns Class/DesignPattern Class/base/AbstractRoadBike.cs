﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Class
{
    public abstract class AbstractRoadBike : AbstractBike
    {

        public AbstractRoadBike()
                : this(BikeColor.Chrome) { }

    }



        public AbstractRoadBike(BikeColor color)
            : base(color)
} }
