using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EItemPoliticaVentaDescuentoRecargo
    {
        public int? ItemCpProrrateosItemPoliticaVentaDescuentoRecargoIddefinicionDescuento { get; set; }
        public decimal? ItemCpProrrateosItemPoliticaVentaDescuentoRecargoPorcentajeDescuentoAplicado { get; set; }
        public decimal? ItemCpProrrateosItemPoliticaVentaDescuentoRecargoPorcentajeDescuentoDefinicion { get; set; }
        public bool? ItemCpProrrateosItemPoliticaVentaDescuentoRecargoSucesivo { get; set; }
        public int ItemCpProrrateosId { get; set; }
        public int ItemCpProrrateosIditemCp { get; set; }
        public int IddescuentoRecargo { get; set; }
        public decimal ItemCpProrrateosMonto { get; set; }
    }
}
