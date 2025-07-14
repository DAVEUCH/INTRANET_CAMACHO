using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ConfiguracionConciliacionBancarium
    {
        public ConfiguracionConciliacionBancarium()
        {
            ConciliacionBancaria = new HashSet<ConciliacionBancarium>();
        }

        public int Pkid { get; set; }
        public int Idcaja { get; set; }
        public int Idmoneda { get; set; }
        public int IdcptoOperacionCpCajaEntrada { get; set; }
        public int IdcptoOperacionCpCajaSalida { get; set; }
        public int IdtipoCpConfirmarMedioDePagoEmitido { get; set; }
        public int IdtipoCpConfirmarMedioDePagoRecibido { get; set; }
        public int IdtipoCpRechazarMedioDePagoEmitido { get; set; }
        public int IdtipoCpRechazarMedioDePagoRecibido { get; set; }
        public int IdtipoCpCajaSalida { get; set; }
        public int IdtipoCpCajaEntrada { get; set; }
        public int IdcuentaContableCpCajaEntrada { get; set; }
        public int IdcuentaContableCpCajaSalida { get; set; }
        public int IdpersonaCpCajaEntrada { get; set; }
        public int IdpersonaCpCajaSalida { get; set; }
        public string IdtipoPersonaCpCajaEntrada { get; set; } = null!;
        public string IdtipoPersonaCpCajaSalida { get; set; } = null!;
        public int IdtipoMedioDePagoCargo { get; set; }
        public int IdtipoMedioDePagoAbono { get; set; }
        public int IdcptoOperacionConfirmarMedioDePagoRecibidoDeEmpleado { get; set; }
        public int IdcptoOperacionConfirmarMedioDePagoRecibidoDeCliente { get; set; }
        public int IdcptoOperacionConfirmarMedioDePagoRecibidoDeProveedor { get; set; }
        public int IdcptoOperacionConfirmarMedioDePagoEmitidoAcliente { get; set; }
        public int IdcptoOperacionConfirmarMedioDePagoEmitidoAempleado { get; set; }
        public int IdcptoOperacionConfirmarMedioDePagoEmitidoAproveedor { get; set; }
        public int IdcptoOperacionRechazarMedioDePagoRecibidoDeCliente { get; set; }
        public int IdcptoOperacionRechazarMedioDePagoRecibidoDeEmpleado { get; set; }
        public int IdcptoOperacionRechazarMedioDePagoRecibidoDeProveedor { get; set; }
        public int IdcptoOperacionRechazarMedioDePagoEmitidoAempleado { get; set; }
        public int IdcptoOperacionRechazarMedioDePagoEmitidoAcliente { get; set; }
        public int IdcptoOperacionRechazarMedioDePagoEmitidoAproveedor { get; set; }
        public int IdcentroDeCostoCpCajaEntrada { get; set; }
        public int IdcentroDeCostoCpCajaSalida { get; set; }
        public int? IdcptoOperacionConfirmarMedioDePagoRecibidoDePersona { get; set; }
        public int? IdcptoOperacionConfirmarMedioDePagoEmitidoApersona { get; set; }
        public int? IdcptoOperacionRechazarMedioDePagoRecibidoDePersona { get; set; }
        public int? IdcptoOperacionRechazarMedioDePagoEmitidoApersona { get; set; }

        public virtual Caja IdcajaNavigation { get; set; } = null!;
        public virtual CentroDeCosto IdcentroDeCostoCpCajaSalidaNavigation { get; set; } = null!;
        public virtual CptoOperacion IdcptoOperacionConfirmarMedioDePagoEmitidoAclienteNavigation { get; set; } = null!;
        public virtual CptoOperacion IdcptoOperacionConfirmarMedioDePagoEmitidoAempleadoNavigation { get; set; } = null!;
        public virtual CptoOperacion IdcptoOperacionConfirmarMedioDePagoEmitidoAproveedorNavigation { get; set; } = null!;
        public virtual CptoOperacion IdcptoOperacionConfirmarMedioDePagoRecibidoDeClienteNavigation { get; set; } = null!;
        public virtual CptoOperacion IdcptoOperacionConfirmarMedioDePagoRecibidoDeEmpleadoNavigation { get; set; } = null!;
        public virtual CptoOperacion IdcptoOperacionConfirmarMedioDePagoRecibidoDeProveedorNavigation { get; set; } = null!;
        public virtual CptoOperacion IdcptoOperacionCpCajaEntradaNavigation { get; set; } = null!;
        public virtual CptoOperacion IdcptoOperacionCpCajaSalidaNavigation { get; set; } = null!;
        public virtual CptoOperacion IdcptoOperacionRechazarMedioDePagoEmitidoAclienteNavigation { get; set; } = null!;
        public virtual CptoOperacion IdcptoOperacionRechazarMedioDePagoEmitidoAempleadoNavigation { get; set; } = null!;
        public virtual CptoOperacion IdcptoOperacionRechazarMedioDePagoEmitidoAproveedorNavigation { get; set; } = null!;
        public virtual CptoOperacion IdcptoOperacionRechazarMedioDePagoRecibidoDeClienteNavigation { get; set; } = null!;
        public virtual CptoOperacion IdcptoOperacionRechazarMedioDePagoRecibidoDeEmpleadoNavigation { get; set; } = null!;
        public virtual CptoOperacion IdcptoOperacionRechazarMedioDePagoRecibidoDeProveedorNavigation { get; set; } = null!;
        public virtual CuentaContable IdcuentaContableCpCajaEntradaNavigation { get; set; } = null!;
        public virtual CuentaContable IdcuentaContableCpCajaSalidaNavigation { get; set; } = null!;
        public virtual Persona IdpersonaCpCajaEntradaNavigation { get; set; } = null!;
        public virtual Persona IdpersonaCpCajaSalidaNavigation { get; set; } = null!;
        public virtual TipoCp IdtipoCpCajaEntradaNavigation { get; set; } = null!;
        public virtual TipoCp IdtipoCpCajaSalidaNavigation { get; set; } = null!;
        public virtual TipoCp IdtipoCpConfirmarMedioDePagoEmitidoNavigation { get; set; } = null!;
        public virtual TipoCp IdtipoCpConfirmarMedioDePagoRecibidoNavigation { get; set; } = null!;
        public virtual TipoCp IdtipoCpRechazarMedioDePagoEmitidoNavigation { get; set; } = null!;
        public virtual TipoCp IdtipoCpRechazarMedioDePagoRecibidoNavigation { get; set; } = null!;
        public virtual Clasificador IdtipoPersonaCpCajaEntradaNavigation { get; set; } = null!;
        public virtual Clasificador IdtipoPersonaCpCajaSalidaNavigation { get; set; } = null!;
        public virtual ICollection<ConciliacionBancarium> ConciliacionBancaria { get; set; }
    }
}
