using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ConsolidadoCarga
    {
        public ConsolidadoCarga()
        {
            CobranzaConsolidadoCargas = new HashSet<CobranzaConsolidadoCarga>();
            GastoConsolidadoCargas = new HashSet<GastoConsolidadoCarga>();
            ItemCpVentaConsolidadoCargas = new HashSet<ItemCpVentaConsolidadoCarga>();
            ItemDocCobrarPagarConsolidadoCargas = new HashSet<ItemDocCobrarPagarConsolidadoCarga>();
            ItemNotaCreditoConsolidadoCargas = new HashSet<ItemNotaCreditoConsolidadoCarga>();
            ItemOrdenAnulacionConsolidadoCargas = new HashSet<ItemOrdenAnulacionConsolidadoCarga>();
            ItemPercepcionConsolidadoCargas = new HashSet<ItemPercepcionConsolidadoCarga>();
            OrdenAnulacions = new HashSet<OrdenAnulacion>();
            PrestamoConsolidadoCargas = new HashSet<PrestamoConsolidadoCarga>();
            SalidaCajaPorGastosConsolidadoCargas = new HashSet<SalidaCajaPorGastosConsolidadoCarga>();
        }

        public int Pkid { get; set; }
        public int IdtipoCp { get; set; }
        public DateTime Fecha { get; set; }
        public bool Cerrado { get; set; }
        public bool RealizoTransferencia { get; set; }
        public decimal MontoDevolucionTotal { get; set; }
        public decimal MontoDevolucionParcial { get; set; }
        public decimal MontoNeto { get; set; }
        public decimal MontoTotal { get; set; }
        public decimal Peso { get; set; }
        public decimal Volumen { get; set; }
        public string NumCp { get; set; } = null!;
        public int Idvehiculo { get; set; }
        public int Idchofer { get; set; }
        public int Idestado { get; set; }
        public DateTime? RegFechayHora { get; set; }

        public virtual Persona IdchoferNavigation { get; set; } = null!;
        public virtual TipoCp IdtipoCpNavigation { get; set; } = null!;
        public virtual Vehiculo IdvehiculoNavigation { get; set; } = null!;
        public virtual ICollection<CobranzaConsolidadoCarga> CobranzaConsolidadoCargas { get; set; }
        public virtual ICollection<GastoConsolidadoCarga> GastoConsolidadoCargas { get; set; }
        public virtual ICollection<ItemCpVentaConsolidadoCarga> ItemCpVentaConsolidadoCargas { get; set; }
        public virtual ICollection<ItemDocCobrarPagarConsolidadoCarga> ItemDocCobrarPagarConsolidadoCargas { get; set; }
        public virtual ICollection<ItemNotaCreditoConsolidadoCarga> ItemNotaCreditoConsolidadoCargas { get; set; }
        public virtual ICollection<ItemOrdenAnulacionConsolidadoCarga> ItemOrdenAnulacionConsolidadoCargas { get; set; }
        public virtual ICollection<ItemPercepcionConsolidadoCarga> ItemPercepcionConsolidadoCargas { get; set; }
        public virtual ICollection<OrdenAnulacion> OrdenAnulacions { get; set; }
        public virtual ICollection<PrestamoConsolidadoCarga> PrestamoConsolidadoCargas { get; set; }
        public virtual ICollection<SalidaCajaPorGastosConsolidadoCarga> SalidaCajaPorGastosConsolidadoCargas { get; set; }
    }
}
