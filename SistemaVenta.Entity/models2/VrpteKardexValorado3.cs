using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteKardexValorado3
    {
        public int Idsucursal { get; set; }
        public int Idalmacen { get; set; }
        public int IdclaseProductoServicio { get; set; }
        public int Idmarca { get; set; }
        public int? Idproveedor { get; set; }
        public int IdconceptoOperacion { get; set; }
        public int Pkid { get; set; }
        public int Idproducto { get; set; }
        public string ProductoCodigo { get; set; } = null!;
        public string ProductoDescripcion { get; set; } = null!;
        public string ComprobanteTipo { get; set; } = null!;
        public string ComprobanteNumCp { get; set; } = null!;
        public DateTime ComprobanteFecha { get; set; }
        public DateTime ComprobanteFechaEmision { get; set; }
        public string? PersonaNombre { get; set; }
        public string ConceptoOperacionCodigo { get; set; } = null!;
        public string ConceptoOperacionDescripcion { get; set; } = null!;
        public string UnidadBaseAbreviacion { get; set; } = null!;
        public string UnidadReferenciaAbreviacion { get; set; } = null!;
        public int ProductoUnidadReferenciaFactor { get; set; }
        public int? Cantidad { get; set; }
        public decimal? ValorVenta { get; set; }
        public decimal? CostoPromedio { get; set; }
        public bool AfectaCostoPromedio { get; set; }
        public string ClaseProductoCodigo { get; set; } = null!;
        public string ClaseProductoDescripcion { get; set; } = null!;
        public int IdclaseProductoServicioPadre { get; set; }
        public decimal? ItemValorUnitario { get; set; }
        public bool ItemCondicionInafecto { get; set; }
        public decimal? ItemValorAfecto { get; set; }
        public decimal? ItemValorVenta { get; set; }
        public decimal? ItemSubTotal { get; set; }
        public decimal? ItemValorDescuento { get; set; }
        public decimal? ItemValorInafecto { get; set; }
        public decimal? ItemTotal { get; set; }
        public string SucursalNombre { get; set; } = null!;
        public int Idperiodo { get; set; }
        public int CantidadBaseReferencial { get; set; }
        public string IdtipoAsociado { get; set; } = null!;
    }
}
