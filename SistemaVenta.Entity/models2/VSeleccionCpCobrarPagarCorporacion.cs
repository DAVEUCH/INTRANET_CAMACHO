using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VSeleccionCpCobrarPagarCorporacion
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string TipoCp { get; set; } = null!;
        public string Sucursal { get; set; } = null!;
        public string Moneda { get; set; } = null!;
        public DateTime FechaVencimiento { get; set; }
        public decimal Saldo { get; set; }
        public decimal Total { get; set; }
        public string? PersonaNombre { get; set; }
        public string NumCp { get; set; } = null!;
        public int Idpersona { get; set; }
        public int Idmoneda { get; set; }
        public string TipoCpCobrarPagar { get; set; } = null!;
        public bool SujetoAdetraccion { get; set; }
        public bool SujetoApercepcion { get; set; }
        public decimal MontoPercepcion { get; set; }
        public bool Credito { get; set; }
        public string? Cuenta { get; set; }
    }
}
