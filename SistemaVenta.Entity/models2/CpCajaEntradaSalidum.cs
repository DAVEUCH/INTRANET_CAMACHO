using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class CpCajaEntradaSalidum
    {
        public int Id { get; set; }
        public string TipoCpCajaDescripcion { get; set; } = null!;
        public string TipoCpCajaAbreviacion { get; set; } = null!;
        public bool FactorNumerico { get; set; }
        public string? FactorCadena { get; set; }
    }
}
