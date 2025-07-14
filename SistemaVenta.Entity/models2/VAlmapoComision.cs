using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VAlmapoComision
    {
        public int? Idcaracteristica5 { get; set; }
        public int CategoriaCliente { get; set; }
        public int Credito { get; set; }
        public decimal Comision { get; set; }
        public int Dias { get; set; }
    }
}
