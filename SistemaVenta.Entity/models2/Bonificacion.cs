using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Bonificacion
    {
        public Bonificacion()
        {
            CanalBonificacions = new HashSet<CanalBonificacion>();
            ItemJerarquiaBonificaciones = new HashSet<ItemJerarquiaBonificacione>();
            MarcaAuspiciadors = new HashSet<MarcaAuspiciador>();
            ProductoAuspiciadors = new HashSet<ProductoAuspiciador>();
            ProductoObsequios = new HashSet<ProductoObsequio>();
            ProveedorAuspiciadors = new HashSet<ProveedorAuspiciador>();
            SucursalBonificacions = new HashSet<SucursalBonificacion>();
            TipoClienteBonificacions = new HashSet<TipoClienteBonificacion>();
        }

        public int Pkid { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string TipoBonificacion { get; set; } = null!;
        public decimal Desde { get; set; }
        public decimal Hasta { get; set; }
        public bool PorMonto { get; set; }
        public bool Activo { get; set; }
        public bool EsGrupo { get; set; }
        public string CondicionGrupo { get; set; } = null!;
        public decimal CondicionDeRango { get; set; }
        public bool TieneVigencia { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public bool ActivoNotaCredito { get; set; }

        public virtual ICollection<CanalBonificacion> CanalBonificacions { get; set; }
        public virtual ICollection<ItemJerarquiaBonificacione> ItemJerarquiaBonificaciones { get; set; }
        public virtual ICollection<MarcaAuspiciador> MarcaAuspiciadors { get; set; }
        public virtual ICollection<ProductoAuspiciador> ProductoAuspiciadors { get; set; }
        public virtual ICollection<ProductoObsequio> ProductoObsequios { get; set; }
        public virtual ICollection<ProveedorAuspiciador> ProveedorAuspiciadors { get; set; }
        public virtual ICollection<SucursalBonificacion> SucursalBonificacions { get; set; }
        public virtual ICollection<TipoClienteBonificacion> TipoClienteBonificacions { get; set; }
    }
}
