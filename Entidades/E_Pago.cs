﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Club_Demo.Entidades
{
    internal class E_Pago
    {
        public int idPago { get; set; }
        public int idPers { get; set; }
        public double monto { get; set; }
        public DateTime fechaPago { get; set; }


    }
}
