using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvTransferenciasCajaCheque
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public string TipoCp { get; set; } = null!;
        public string NumCp { get; set; } = null!;
        public string Concepto { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string Sucursal { get; set; } = null!;
        public string Simbolo { get; set; } = null!;
        public int CajaId { get; set; }
        public string NombreCaja { get; set; } = null!;
        public string MedioDePagoGiradoA { get; set; } = null!;
        public DateTime MedioDePagoFechaEmision { get; set; }
        public DateTime MedioDePagoFechaPago { get; set; }
        public string MedioDePagoEstado { get; set; } = null!;
        public string MedioDePagoNumeroDeCheque { get; set; } = null!;
        public decimal MedioDePagoTotal { get; set; }
        public string MedioDePagoPersonaNombre { get; set; } = null!;
        public string MedioDePagoObservacion { get; set; } = null!;
        public string EstadoAnulado { get; set; } = null!;
        public string? PersonaResponsable { get; set; }
    }
}
