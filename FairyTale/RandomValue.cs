﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyTale
{
    class RandomValue
    {
        public int GenerateRandom(int maxValue)
        {
            Random random = new Random();
            return random.Next(0, maxValue);
        }
    }
}
