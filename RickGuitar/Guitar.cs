﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RickGuitar;

namespace RickGuitar
{
    public class Guitar : Instrument
    {
        public Guitar(string serialNumber, double price, GuitarSpec guitarSpec) : base(serialNumber, price, guitarSpec)
        {
        }
    }
}
