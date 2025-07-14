using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvInventarioEntradasPorProductoCodigosSinVinculadaImportVinc
    {
        public int Idsucursal { get; set; }
        public string TipoCp { get; set; } = null!;
        public string NumCp { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public int? Año { get; set; }
        public int? Semestre { get; set; }
        public int? Trimestre { get; set; }
        public int? Mes { get; set; }
        public int Idpersona { get; set; }
        public int Idresponsable { get; set; }
        public int Idproducto { get; set; }
        public string Codigo { get; set; } = null!;
        public int FactorUnidadReferencia { get; set; }
        public decimal Cantidad { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorVenta { get; set; }
        public decimal Total { get; set; }
    }
}
