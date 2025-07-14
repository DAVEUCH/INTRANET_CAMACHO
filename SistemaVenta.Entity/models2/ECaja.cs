using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ECaja
    {
        public int Id { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public bool Activo { get; set; }
        public int Idmoneda { get; set; }
        public int Idbanco { get; set; }
        public int Idsucursal { get; set; }
        public decimal SaldoSoles { get; set; }
        public decimal SaldoDolares { get; set; }
        public decimal SaldoDisponibleSoles { get; set; }
        public decimal SaldoDisponibleDolares { get; set; }
        public bool Sobregirable { get; set; }
        public decimal SobregiroSoles { get; set; }
        public decimal SobregiroDolares { get; set; }
        public bool EsBanco { get; set; }
        public string NumeroCheque { get; set; } = null!;
        public string NumeroCuenta { get; set; } = null!;
        public int NumeroDigitos { get; set; }
        public bool RestringirMoneda { get; set; }
        public bool GestionaTurnos { get; set; }
        public int IdtipoCaja { get; set; }
        public int IdcuentaContable { get; set; }
    }
}
