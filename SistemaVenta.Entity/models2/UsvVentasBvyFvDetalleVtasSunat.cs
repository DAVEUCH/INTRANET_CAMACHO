using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvVentasBvyFvDetalleVtasSunat
    {
        public int Pkid { get; set; }
        public string Descripcion { get; set; } = null!;
        public string NumCp { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public int Idperiodo { get; set; }
        public int Idpersona { get; set; }
        public decimal MontoPercepcion { get; set; }
        public string? RucCliente { get; set; }
        public string? RazonSocialCliente { get; set; }
        public string CodigoRefBien { get; set; } = null!;
        public string TipoComp { get; set; } = null!;
        public decimal BaseImponible { get; set; }
        public decimal? Igv { get; set; }
    }
}
