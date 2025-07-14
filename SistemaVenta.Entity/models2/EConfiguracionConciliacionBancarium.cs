using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EConfiguracionConciliacionBancarium
    {
        public int Id { get; set; }
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
        public int? IdcptoOperacionRechazarMedioDePagoEmitidoApersona { get; set; }
        public int? IdcptoOperacionRechazarMedioDePagoRecibidoDePersona { get; set; }
    }
}
