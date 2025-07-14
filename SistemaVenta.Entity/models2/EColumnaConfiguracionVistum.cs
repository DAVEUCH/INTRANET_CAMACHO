using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EColumnaConfiguracionVistum
    {
        public string ColumnasId { get; set; } = null!;
        public string ColumnasTexto { get; set; } = null!;
        public int ColumnasAncho { get; set; }
        public string ColumnasFormato { get; set; } = null!;
        public int ColumnasIcono { get; set; }
        public string ColumnasNombreAtributo { get; set; } = null!;
        public int ColumnasTipoDato { get; set; }
        public int ColumnasAlineacion { get; set; }
        public int ColumnasOrden { get; set; }
        public bool ColumnasOrdenamientoPorDefecto { get; set; }
        public string ColumnasNombreSql { get; set; } = null!;
        public bool ColumnasTag { get; set; }
        public bool ColumnasVisible { get; set; }
        public string IdconfiguracionVista { get; set; } = null!;
        public string Texto { get; set; } = null!;
        public int Ancho { get; set; }
        public string Formato { get; set; } = null!;
        public int Icono { get; set; }
        public string NombreAtributo { get; set; } = null!;
        public int TipoDato { get; set; }
        public int Alineacion { get; set; }
        public int Orden { get; set; }
        public bool OrdenamientoPorDefecto { get; set; }
        public string NombreSql { get; set; } = null!;
        public bool Tag { get; set; }
        public bool Visible { get; set; }
        public string Id { get; set; } = null!;
    }
}
