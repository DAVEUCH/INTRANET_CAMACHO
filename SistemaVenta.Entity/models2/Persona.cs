using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Persona
    {
        public Persona()
        {
            ConciliacionBancaria = new HashSet<ConciliacionBancarium>();
            ConfiguracionCierreAperturas = new HashSet<ConfiguracionCierreApertura>();
            ConfiguracionConciliacionBancariumIdpersonaCpCajaEntradaNavigations = new HashSet<ConfiguracionConciliacionBancarium>();
            ConfiguracionConciliacionBancariumIdpersonaCpCajaSalidaNavigations = new HashSet<ConfiguracionConciliacionBancarium>();
            ConfiguracionTransferencia = new HashSet<ConfiguracionTransferencium>();
            ConsolidadoCargas = new HashSet<ConsolidadoCarga>();
            Contactos = new HashSet<Contacto>();
            CpIdpersonaNavigations = new HashSet<Cp>();
            CpIdresponsableNavigations = new HashSet<Cp>();
            CpOrdenPagos = new HashSet<CpOrdenPago>();
            DireccionZonas = new HashSet<DireccionZona>();
            Direccions = new HashSet<Direccion>();
            GrupoVenta = new HashSet<GrupoVenta>();
            ListaPrecios = new HashSet<ListaPrecio>();
            ListaPreciosProveedors = new HashSet<ListaPreciosProveedor>();
            MedioDePagos = new HashSet<MedioDePago>();
            OrdenAnulacions = new HashSet<OrdenAnulacion>();
            Productos = new HashSet<Producto>();
            ProveedorItemSolicitudCompras = new HashSet<ProveedorItemSolicitudCompra>();
            Telefonos = new HashSet<Telefono>();
            TurnoCajas = new HashSet<TurnoCaja>();
            VehiculoIdempleadoNavigations = new HashSet<Vehiculo>();
            VehiculoIdproveedorNavigations = new HashSet<Vehiculo>();
            VoucherContables = new HashSet<VoucherContable>();
        }

        public int Pkid { get; set; }
        public int IdtipoTercero { get; set; }
        public int IdtipoDocIdentidad { get; set; }
        public string Email { get; set; } = null!;
        public string Web { get; set; } = null!;
        public string Observacion { get; set; } = null!;
        public string? DocIdentidad { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string ApellidoPaterno { get; set; } = null!;
        public string ApellidoMaterno { get; set; } = null!;
        public string PrimerNombre { get; set; } = null!;
        public string SegundoNombre { get; set; } = null!;
        public bool Descriptivo { get; set; }
        public bool Activo { get; set; }
        public bool AgenteRetencion { get; set; }
        public bool AgentePercepcion { get; set; }
        public bool Extranjero { get; set; }
        public string CuentaBancaria { get; set; } = null!;
        public DateTime FechaAniversario { get; set; }
        public DateTime FechaCumpleaños { get; set; }
        public int IddireccionPrincipal { get; set; }
        public bool ExceptuadoDePercepcion { get; set; }
        public DateTime? FechaCrea { get; set; }

        public virtual TipoDocIdentidad IdtipoDocIdentidadNavigation { get; set; } = null!;
        public virtual TipoTercero IdtipoTerceroNavigation { get; set; } = null!;
        public virtual Cliente Cliente { get; set; } = null!;
        public virtual Empleado Empleado { get; set; } = null!;
        public virtual ICollection<ConciliacionBancarium> ConciliacionBancaria { get; set; }
        public virtual ICollection<ConfiguracionCierreApertura> ConfiguracionCierreAperturas { get; set; }
        public virtual ICollection<ConfiguracionConciliacionBancarium> ConfiguracionConciliacionBancariumIdpersonaCpCajaEntradaNavigations { get; set; }
        public virtual ICollection<ConfiguracionConciliacionBancarium> ConfiguracionConciliacionBancariumIdpersonaCpCajaSalidaNavigations { get; set; }
        public virtual ICollection<ConfiguracionTransferencium> ConfiguracionTransferencia { get; set; }
        public virtual ICollection<ConsolidadoCarga> ConsolidadoCargas { get; set; }
        public virtual ICollection<Contacto> Contactos { get; set; }
        public virtual ICollection<Cp> CpIdpersonaNavigations { get; set; }
        public virtual ICollection<Cp> CpIdresponsableNavigations { get; set; }
        public virtual ICollection<CpOrdenPago> CpOrdenPagos { get; set; }
        public virtual ICollection<DireccionZona> DireccionZonas { get; set; }
        public virtual ICollection<Direccion> Direccions { get; set; }
        public virtual ICollection<GrupoVenta> GrupoVenta { get; set; }
        public virtual ICollection<ListaPrecio> ListaPrecios { get; set; }
        public virtual ICollection<ListaPreciosProveedor> ListaPreciosProveedors { get; set; }
        public virtual ICollection<MedioDePago> MedioDePagos { get; set; }
        public virtual ICollection<OrdenAnulacion> OrdenAnulacions { get; set; }
        public virtual ICollection<Producto> Productos { get; set; }
        public virtual ICollection<ProveedorItemSolicitudCompra> ProveedorItemSolicitudCompras { get; set; }
        public virtual ICollection<Telefono> Telefonos { get; set; }
        public virtual ICollection<TurnoCaja> TurnoCajas { get; set; }
        public virtual ICollection<Vehiculo> VehiculoIdempleadoNavigations { get; set; }
        public virtual ICollection<Vehiculo> VehiculoIdproveedorNavigations { get; set; }
        public virtual ICollection<VoucherContable> VoucherContables { get; set; }
    }
}
