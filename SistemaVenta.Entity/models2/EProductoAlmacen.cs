using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EProductoAlmacen
    {
        public int ProductoAlmacenesId { get; set; }
        public int ProductoIdproducto { get; set; }
        public int ProductoAlmacenesIdalmacen { get; set; }
        public int ProductoAlmacenesIdseccionAlmacen { get; set; }
        public int ProductoAlmacenesCapacidad { get; set; }
        public int ProductoAlmacenesStockFisico { get; set; }
        public int ProductoAlmacenesStockContable { get; set; }
        public int ProductoAlmacenesStockPorEntregar { get; set; }
        public int ProductoAlmacenesStockPorRecibir { get; set; }
        public int ProductoAlmacenesTiempoDeEntrega { get; set; }
        public int ProductoAlmacenesFrecuenciaDeCompra { get; set; }
        public int ProductoAlmacenesTiempoDeSeguridad { get; set; }
        public decimal ProductoAlmacenesNivelReposicion { get; set; }
        public int ProductoAlmacenesCantidadMinima { get; set; }
        public int ProductoAlmacenesStockMinimo { get; set; }
        public int ProductoAlmacenesStockMaximo { get; set; }
    }
}
