using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Club_Demo.Entidades
{
    internal class E_Cuota
    {
        public DateTime FechaPagoC {  get; set; }
        public string TipoCuota { get; set; }
        public double Monto { get; set; }
        public string Estado { get; set; }
       // public int idPago { get; set; }
        public int IdPers { get; set; }
    }
}
