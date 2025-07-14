using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteKardexNoValorado
    {
        public int Idsucursal { get; set; }
        public int Idalmacen { get; set; }
        public int IdclaseProductoServicio { get; set; }
        public int Idmarca { get; set; }
        public int? Idproveedor { get; set; }
        public int IdconceptoOperacion { get; set; }
        public int Idcp { get; set; }
        public int Idproducto { get; set; }
        public string ProductoCodigo { get; set; } = null!;
        public string ProductoDescripcion { get; set; } = null!;
        public string ComprobanteTipo { get; set; } = null!;
        public string ComprobanteNumCp { get; set; } = null!;
        public DateTime ComprobanteFecha { get; set; }
        public DateTime ComprobanteFechaEmision { get; set; }
        public string? OrigenDestinoNombre { get; set; }
        public string ConceptoOperacionCodigo { get; set; } = null!;
        public string ConceptoOperacionDescripcion { get; set; } = null!;
        public string UnidadBaseAbreviacion { get; set; } = null!;
        public string UnidadReferenciaAbreviacion { get; set; } = null!;
        public int ProductoUnidadReferenciaFactor { get; set; }
        public int? MovimientoEntradaUbase { get; set; }
        public int? MovimientoSalidaUbase { get; set; }
        public string Lote { get; set; } = null!;
        public DateTime LoteFechaIngreso { get; set; }
        public DateTime LoteFechaVencimiento { get; set; }
    }
}
