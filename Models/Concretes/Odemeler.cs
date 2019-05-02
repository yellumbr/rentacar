﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Models.Concretes
{
    public class Odemeler
    {
        public Odemeler()
        {
           
        }
        public int OdemeID { get; set; }
        public decimal OdemeMiktari { get; set; }
        public bool OdemeBasarili { get; set; }

        public DateTime OdemeTarihi { get; set; }

        public int MusteriId { get; set; }
    }
}
