using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TmpstocksFre
    {
        public int Idsucursal { get; set; }
        public int Idalmacen { get; set; }
        public int IdclaseProductoServicio { get; set; }
        public int Idmarca { get; set; }
        public int? Idproveedor { get; set; }
        public string CodigoProveedor { get; set; } = null!;
        public string NombreProveedor { get; set; } = null!;
        public int IdconceptoOperacion { get; set; }
        public int Pkid { get; set; }
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
        public string UnidadReferenciaCodigo { get; set; } = null!;
        public int UnidadReferenciaFactor { get; set; }
        public int? Cantidad { get; set; }
        public decimal ValorUnitario { get; set; }
        public string ClaseProductoCodigo { get; set; } = null!;
        public string ClaseProductoDescripcion { get; set; } = null!;
        public int IdclaseProductoServicioPadre { get; set; }
        public string SucursalNombre { get; set; } = null!;
        public int Idperiodo { get; set; }
        public string TipoComprobantePagoCodigo { get; set; } = null!;
        public string TipoComprobantePagoDescripcion { get; set; } = null!;
        public string TipoExistenciaCodigo { get; set; } = null!;
        public string TipoExistenciaDescripcion { get; set; } = null!;
        public string TipoOperacionCodigo { get; set; } = null!;
        public string TipoOperacionDescripcion { get; set; } = null!;
        public string CodigoAlmacen { get; set; } = null!;
        public string NombreAlmacen { get; set; } = null!;
    }
}
