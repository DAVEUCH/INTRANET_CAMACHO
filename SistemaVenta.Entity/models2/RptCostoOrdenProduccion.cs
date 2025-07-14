using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class RptCostoOrdenProduccion
    {
        public int Ocid { get; set; }
        public string Octipo { get; set; } = null!;
        public string Ocnumero { get; set; } = null!;
        public DateTime Ocfecha { get; set; }
        public string PersonaNombre { get; set; } = null!;
        public decimal Octotal { get; set; }
        public string EstadoSalida { get; set; } = null!;
        public string EstadoEntrada { get; set; } = null!;
        public string EstadoAprobacion { get; set; } = null!;
        public bool Cerrado { get; set; }
        public string Observacion { get; set; } = null!;
        public decimal CantidadReal { get; set; }
        public decimal BalanceEntrada { get; set; }
        public string ProductoCodigo { get; set; } = null!;
        public string ProductoNombre { get; set; } = null!;
        public string UnidadNombre { get; set; } = null!;
        public int ProductoFactor { get; set; }
        public decimal ProductoCantidad { get; set; }
        public decimal? ProductoCostoPromedioFecha { get; set; }
        public string RecetaProdCodigo { get; set; } = null!;
        public string RecetaProdNombre { get; set; } = null!;
        public string RecetaProdUnidad { get; set; } = null!;
        public int RecetaProdFactor { get; set; }
        public int RecetaProdCantidadBase { get; set; }
        public decimal RecetaBalanceEntrega { get; set; }
        public decimal? RecetaCostoUltimaCompra { get; set; }
        public decimal? RecetaCostoPromedioFecha { get; set; }
        public string NumCpNivel2 { get; set; } = null!;
        public string DescripcionCpNivel2 { get; set; } = null!;
        public int? IdcptoOperacion { get; set; }
        public int? Pkid { get; set; }
        public int IdtipoProductoServicio { get; set; }
    }
}
