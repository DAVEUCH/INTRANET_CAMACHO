using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ConfiguracionCpInventario
    {
        public int Pkid { get; set; }
        public bool CostoPromedio { get; set; }
        public int CostoPromedioCantidad { get; set; }
        public int CostoPromedioMonto { get; set; }
        public bool CostoUltimaCompra { get; set; }
        public bool CostoReferencia { get; set; }
        public bool CostoParalelo { get; set; }
        public int StockFisico { get; set; }
        public int StockContable { get; set; }
        public int StockPorEntregar { get; set; }
        public int StockPorRecibir { get; set; }
        public string PropiedadEstadoAsociado { get; set; } = null!;
        public string PropiedadBalanceAsociado { get; set; } = null!;
        public bool ActualizaEstadoBalance { get; set; }
        public bool GestionaLote { get; set; }
        public bool? RestringirAlmacenItem { get; set; }
        public string TipoMovimiento { get; set; } = null!;
        public int IdtipoOperacion { get; set; }
        public bool SugerenciaCompra { get; set; }
        public bool RequiereCentroDeCosto { get; set; }
        public bool UsarUnidadMedida { get; set; }

        public virtual TipoOperacion IdtipoOperacionNavigation { get; set; } = null!;
        public virtual CptoOperacion Pk { get; set; } = null!;
    }
}
