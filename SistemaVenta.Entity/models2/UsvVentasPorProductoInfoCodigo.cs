using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvVentasPorProductoInfoCodigo
    {
        public int IdDocVenta { get; set; }
        public string TipoCp { get; set; } = null!;
        public int Idsucursal { get; set; }
        public string NumeroDocVta { get; set; } = null!;
        public int ClienteId { get; set; }
        public string ClienteNombre { get; set; } = null!;
        public string Vendedor { get; set; } = null!;
        public int EsCompraCp { get; set; }
        public DateTime Fecha { get; set; }
        public int Idperiodo { get; set; }
        public int? ProductoId { get; set; }
        public decimal? ValorUnitario { get; set; }
        public decimal? ValorVentaSoles { get; set; }
        public decimal? Cantidad { get; set; }
    }
}
