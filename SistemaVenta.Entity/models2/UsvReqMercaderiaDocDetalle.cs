using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvReqMercaderiaDocDetalle
    {
        public int Id { get; set; }
        public string TipoCp { get; set; } = null!;
        public string NumCp { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public int Idsucursal { get; set; }
        public string Sucursal { get; set; } = null!;
        public int IdsucursalSalida { get; set; }
        public string SucursalSalida { get; set; } = null!;
        public string EstadoEntrega { get; set; } = null!;
        public string EstadoRecepcion { get; set; } = null!;
        public string Aentrada { get; set; } = null!;
        public string Asalida { get; set; } = null!;
        public int Idproducto { get; set; }
        public string Codigo { get; set; } = null!;
        public int? CantUnidadStockAnterior { get; set; }
        public int CantUnidadesReqMat { get; set; }
        public int? CantUnidadVendida { get; set; }
        public int? CantUnidadStockFinal { get; set; }
    }
}
