﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RickGuitar;

namespace RickGuitar
{
    public class Instrument
    {
        public string SerialNumber { get; set; }
        public double Price { get; set; }
        public InstrumentSpec Spec { get; set; }

        public Instrument(string serialNumber, double price, InstrumentSpec spec) 
        {
            this.SerialNumber = serialNumber;
            this.Price = price;
            this.Spec = spec;
        }

        public override string ToString()
        {
            return $"Serial Number: {SerialNumber}, Pice: {Price}, Spec: {Spec}";
        }
    }
}
