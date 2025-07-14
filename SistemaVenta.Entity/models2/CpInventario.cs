using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class CpInventario
    {
        public CpInventario()
        {
            ActivoFijoCpActivoFijoEntrada = new HashSet<ActivoFijoCpActivoFijoEntradum>();
            ActivoFijoCpActivoFijoSalida = new HashSet<ActivoFijoCpActivoFijoSalidum>();
            ActivoFijoCpActivoFijoTransferenciumIdcpActivoFijoEntradaNavigations = new HashSet<ActivoFijoCpActivoFijoTransferencium>();
            ActivoFijoCpActivoFijoTransferenciumIdcpActivoFijoSalidaNavigations = new HashSet<ActivoFijoCpActivoFijoTransferencium>();
            CpImportacion2s = new HashSet<CpImportacion2>();
            CpImportacionIdcpInventarioEntradaNavigations = new HashSet<CpImportacion>();
            CpImportacionIdcpInventarioSalidaNavigations = new HashSet<CpImportacion>();
            CpInventarioEntrada = new HashSet<CpInventarioEntradum>();
            CpInventarioSalida = new HashSet<CpInventarioSalidum>();
            CpInventarioTransferenciumIdcpInventarioEntradaNavigations = new HashSet<CpInventarioTransferencium>();
            CpInventarioTransferenciumIdcpInventarioSalidaNavigations = new HashSet<CpInventarioTransferencium>();
            ItemProductoAlmacens = new HashSet<ItemProductoAlmacen>();
            Pedidos = new HashSet<Pedido>();
        }

        public int Pkid { get; set; }
        public int Idcp { get; set; }
        public int Idalmacen { get; set; }
        public int MovStockContable { get; set; }
        public int MovStockFisico { get; set; }
        public int MovStockPorEntregar { get; set; }
        public int MovStockPorRecibir { get; set; }
        public bool CostoPromedio { get; set; }
        public int CostoPromedioCantidad { get; set; }
        public int CostoPromedioMonto { get; set; }
        public bool CostoUltimaCompra { get; set; }
        public bool CostoReferencia { get; set; }
        public bool CostoParalelo { get; set; }
        public string TipoCpInventario { get; set; } = null!;
        public decimal Peso { get; set; }
        public decimal Volumen { get; set; }
        public bool SobregirarStockDisponible { get; set; }
        public int IdtipoOperacion { get; set; }
        public bool SugerenciaCompra { get; set; }

        public virtual Almacen IdalmacenNavigation { get; set; } = null!;
        public virtual Cp IdcpNavigation { get; set; } = null!;
        public virtual TipoOperacion IdtipoOperacionNavigation { get; set; } = null!;
        public virtual ICollection<ActivoFijoCpActivoFijoEntradum> ActivoFijoCpActivoFijoEntrada { get; set; }
        public virtual ICollection<ActivoFijoCpActivoFijoSalidum> ActivoFijoCpActivoFijoSalida { get; set; }
        public virtual ICollection<ActivoFijoCpActivoFijoTransferencium> ActivoFijoCpActivoFijoTransferenciumIdcpActivoFijoEntradaNavigations { get; set; }
        public virtual ICollection<ActivoFijoCpActivoFijoTransferencium> ActivoFijoCpActivoFijoTransferenciumIdcpActivoFijoSalidaNavigations { get; set; }
        public virtual ICollection<CpImportacion2> CpImportacion2s { get; set; }
        public virtual ICollection<CpImportacion> CpImportacionIdcpInventarioEntradaNavigations { get; set; }
        public virtual ICollection<CpImportacion> CpImportacionIdcpInventarioSalidaNavigations { get; set; }
        public virtual ICollection<CpInventarioEntradum> CpInventarioEntrada { get; set; }
        public virtual ICollection<CpInventarioSalidum> CpInventarioSalida { get; set; }
        public virtual ICollection<CpInventarioTransferencium> CpInventarioTransferenciumIdcpInventarioEntradaNavigations { get; set; }
        public virtual ICollection<CpInventarioTransferencium> CpInventarioTransferenciumIdcpInventarioSalidaNavigations { get; set; }
        public virtual ICollection<ItemProductoAlmacen> ItemProductoAlmacens { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
