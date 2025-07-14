using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class CptoOperacion
    {
        public CptoOperacion()
        {
            AsientoTipos = new HashSet<AsientoTipo>();
            CanjeLetras = new HashSet<CanjeLetra>();
            ConfiguracionConciliacionBancariumIdcptoOperacionConfirmarMedioDePagoEmitidoAclienteNavigations = new HashSet<ConfiguracionConciliacionBancarium>();
            ConfiguracionConciliacionBancariumIdcptoOperacionConfirmarMedioDePagoEmitidoAempleadoNavigations = new HashSet<ConfiguracionConciliacionBancarium>();
            ConfiguracionConciliacionBancariumIdcptoOperacionConfirmarMedioDePagoEmitidoAproveedorNavigations = new HashSet<ConfiguracionConciliacionBancarium>();
            ConfiguracionConciliacionBancariumIdcptoOperacionConfirmarMedioDePagoRecibidoDeClienteNavigations = new HashSet<ConfiguracionConciliacionBancarium>();
            ConfiguracionConciliacionBancariumIdcptoOperacionConfirmarMedioDePagoRecibidoDeEmpleadoNavigations = new HashSet<ConfiguracionConciliacionBancarium>();
            ConfiguracionConciliacionBancariumIdcptoOperacionConfirmarMedioDePagoRecibidoDeProveedorNavigations = new HashSet<ConfiguracionConciliacionBancarium>();
            ConfiguracionConciliacionBancariumIdcptoOperacionCpCajaEntradaNavigations = new HashSet<ConfiguracionConciliacionBancarium>();
            ConfiguracionConciliacionBancariumIdcptoOperacionCpCajaSalidaNavigations = new HashSet<ConfiguracionConciliacionBancarium>();
            ConfiguracionConciliacionBancariumIdcptoOperacionRechazarMedioDePagoEmitidoAclienteNavigations = new HashSet<ConfiguracionConciliacionBancarium>();
            ConfiguracionConciliacionBancariumIdcptoOperacionRechazarMedioDePagoEmitidoAempleadoNavigations = new HashSet<ConfiguracionConciliacionBancarium>();
            ConfiguracionConciliacionBancariumIdcptoOperacionRechazarMedioDePagoEmitidoAproveedorNavigations = new HashSet<ConfiguracionConciliacionBancarium>();
            ConfiguracionConciliacionBancariumIdcptoOperacionRechazarMedioDePagoRecibidoDeClienteNavigations = new HashSet<ConfiguracionConciliacionBancarium>();
            ConfiguracionConciliacionBancariumIdcptoOperacionRechazarMedioDePagoRecibidoDeEmpleadoNavigations = new HashSet<ConfiguracionConciliacionBancarium>();
            ConfiguracionConciliacionBancariumIdcptoOperacionRechazarMedioDePagoRecibidoDeProveedorNavigations = new HashSet<ConfiguracionConciliacionBancarium>();
            ConfiguracionDocCobrarPagars = new HashSet<ConfiguracionDocCobrarPagar>();
            ConfiguracionTransferencia = new HashSet<ConfiguracionTransferencium>();
            CpOrdenPagos = new HashSet<CpOrdenPago>();
            Cps = new HashSet<Cp>();
            CptoOperacionCuentaContables = new HashSet<CptoOperacionCuentaContable>();
        }

        public int Pkid { get; set; }
        public int IdtipoPersona { get; set; }
        public string IdtipoAsociado { get; set; } = null!;
        public string IdtipoOrigen { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int TipoItemCp { get; set; }
        public bool? Activo { get; set; }
        public bool TieneCpInventario { get; set; }
        public bool TieneCpCaja { get; set; }
        public bool TieneCpCobrarPagar { get; set; }
        public bool TieneCpOrigen { get; set; }
        public int IdtipoVoucher { get; set; }
        public bool Contabilizable { get; set; }
        public int IdcuentaContableRedondeoCargo { get; set; }
        public int IdcuentaContableRedondeoAbono { get; set; }
        public string RutaAuxiliarRedondeo { get; set; } = null!;
        public bool TipoCambioEnComprobante { get; set; }
        public string RutaTipoCambio { get; set; } = null!;
        public bool ModificarFechaTipoCambio { get; set; }
        public bool EvaluarDetraccion { get; set; }
        public bool EvaluarPercepcion { get; set; }
        public bool SumarPercepcionAlTotal { get; set; }
        public string RutaMontoPercepcion { get; set; } = null!;

        public virtual Clasificador IdtipoAsociadoNavigation { get; set; } = null!;
        public virtual Clasificador IdtipoOrigenNavigation { get; set; } = null!;
        public virtual TipoPersona IdtipoPersonaNavigation { get; set; } = null!;
        public virtual TipoCp IdtipoVoucherNavigation { get; set; } = null!;
        public virtual ConfiguracionCpCaja ConfiguracionCpCaja { get; set; } = null!;
        public virtual ConfiguracionCpCobrarPagar ConfiguracionCpCobrarPagar { get; set; } = null!;
        public virtual ConfiguracionCpInventario ConfiguracionCpInventario { get; set; } = null!;
        public virtual ConfiguracionRelacion ConfiguracionRelacion { get; set; } = null!;
        public virtual ICollection<AsientoTipo> AsientoTipos { get; set; }
        public virtual ICollection<CanjeLetra> CanjeLetras { get; set; }
        public virtual ICollection<ConfiguracionConciliacionBancarium> ConfiguracionConciliacionBancariumIdcptoOperacionConfirmarMedioDePagoEmitidoAclienteNavigations { get; set; }
        public virtual ICollection<ConfiguracionConciliacionBancarium> ConfiguracionConciliacionBancariumIdcptoOperacionConfirmarMedioDePagoEmitidoAempleadoNavigations { get; set; }
        public virtual ICollection<ConfiguracionConciliacionBancarium> ConfiguracionConciliacionBancariumIdcptoOperacionConfirmarMedioDePagoEmitidoAproveedorNavigations { get; set; }
        public virtual ICollection<ConfiguracionConciliacionBancarium> ConfiguracionConciliacionBancariumIdcptoOperacionConfirmarMedioDePagoRecibidoDeClienteNavigations { get; set; }
        public virtual ICollection<ConfiguracionConciliacionBancarium> ConfiguracionConciliacionBancariumIdcptoOperacionConfirmarMedioDePagoRecibidoDeEmpleadoNavigations { get; set; }
        public virtual ICollection<ConfiguracionConciliacionBancarium> ConfiguracionConciliacionBancariumIdcptoOperacionConfirmarMedioDePagoRecibidoDeProveedorNavigations { get; set; }
        public virtual ICollection<ConfiguracionConciliacionBancarium> ConfiguracionConciliacionBancariumIdcptoOperacionCpCajaEntradaNavigations { get; set; }
        public virtual ICollection<ConfiguracionConciliacionBancarium> ConfiguracionConciliacionBancariumIdcptoOperacionCpCajaSalidaNavigations { get; set; }
        public virtual ICollection<ConfiguracionConciliacionBancarium> ConfiguracionConciliacionBancariumIdcptoOperacionRechazarMedioDePagoEmitidoAclienteNavigations { get; set; }
        public virtual ICollection<ConfiguracionConciliacionBancarium> ConfiguracionConciliacionBancariumIdcptoOperacionRechazarMedioDePagoEmitidoAempleadoNavigations { get; set; }
        public virtual ICollection<ConfiguracionConciliacionBancarium> ConfiguracionConciliacionBancariumIdcptoOperacionRechazarMedioDePagoEmitidoAproveedorNavigations { get; set; }
        public virtual ICollection<ConfiguracionConciliacionBancarium> ConfiguracionConciliacionBancariumIdcptoOperacionRechazarMedioDePagoRecibidoDeClienteNavigations { get; set; }
        public virtual ICollection<ConfiguracionConciliacionBancarium> ConfiguracionConciliacionBancariumIdcptoOperacionRechazarMedioDePagoRecibidoDeEmpleadoNavigations { get; set; }
        public virtual ICollection<ConfiguracionConciliacionBancarium> ConfiguracionConciliacionBancariumIdcptoOperacionRechazarMedioDePagoRecibidoDeProveedorNavigations { get; set; }
        public virtual ICollection<ConfiguracionDocCobrarPagar> ConfiguracionDocCobrarPagars { get; set; }
        public virtual ICollection<ConfiguracionTransferencium> ConfiguracionTransferencia { get; set; }
        public virtual ICollection<CpOrdenPago> CpOrdenPagos { get; set; }
        public virtual ICollection<Cp> Cps { get; set; }
        public virtual ICollection<CptoOperacionCuentaContable> CptoOperacionCuentaContables { get; set; }
    }
}
