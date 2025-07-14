using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TipoCp
    {
        public TipoCp()
        {
            CanjeLetras = new HashSet<CanjeLetra>();
            CargoCobranzas = new HashSet<CargoCobranza>();
            ConfiguracionCierreAperturas = new HashSet<ConfiguracionCierreApertura>();
            ConfiguracionConciliacionBancariumIdtipoCpCajaEntradaNavigations = new HashSet<ConfiguracionConciliacionBancarium>();
            ConfiguracionConciliacionBancariumIdtipoCpCajaSalidaNavigations = new HashSet<ConfiguracionConciliacionBancarium>();
            ConfiguracionConciliacionBancariumIdtipoCpConfirmarMedioDePagoEmitidoNavigations = new HashSet<ConfiguracionConciliacionBancarium>();
            ConfiguracionConciliacionBancariumIdtipoCpConfirmarMedioDePagoRecibidoNavigations = new HashSet<ConfiguracionConciliacionBancarium>();
            ConfiguracionConciliacionBancariumIdtipoCpRechazarMedioDePagoEmitidoNavigations = new HashSet<ConfiguracionConciliacionBancarium>();
            ConfiguracionConciliacionBancariumIdtipoCpRechazarMedioDePagoRecibidoNavigations = new HashSet<ConfiguracionConciliacionBancarium>();
            ConfiguracionDocCobrarPagars = new HashSet<ConfiguracionDocCobrarPagar>();
            ConfiguracionTransferencia = new HashSet<ConfiguracionTransferencium>();
            ConsolidadoCargas = new HashSet<ConsolidadoCarga>();
            Cps = new HashSet<Cp>();
            CptoOperacions = new HashSet<CptoOperacion>();
            LiquidacionCajas = new HashSet<LiquidacionCaja>();
            ListaInventarios = new HashSet<ListaInventario>();
            VoucherContables = new HashSet<VoucherContable>();
        }

        public int Pkid { get; set; }
        public int Idsucursal { get; set; }
        public string IdreporteImpresion { get; set; } = null!;
        public int IdnumCpContable { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Abreviacion { get; set; } = null!;
        public string TipoCp1 { get; set; } = null!;
        public int Numero { get; set; }
        public string Serie { get; set; } = null!;
        public int LongitudNumero { get; set; }
        public int LongitudSerie { get; set; }
        public int MaximoNumeroItems { get; set; }
        public int PeriodoAnulacion { get; set; }
        public bool NumeracionAutomatica { get; set; }
        public bool NumeracionContable { get; set; }
        public bool RequiereMotivoAnulacion { get; set; }
        public bool GenerarNumeracionAlGuardar { get; set; }
        public bool PermitirFechasFuturas { get; set; }
        public bool PermitirFechasDiferidas { get; set; }
        public bool Imprimible { get; set; }
        public int IdtipoComprobantePago { get; set; }
        public bool EsComprobantePago { get; set; }
        public int Idimpuesto { get; set; }
        public bool TieneImpuesto { get; set; }
        public bool PreciosIncImpto { get; set; }
        public bool LibroDiario { get; set; }
        public bool Tercero { get; set; }
        public bool? Activo { get; set; }
        public bool ResumirEnLibroAuxiliar { get; set; }
        public bool PermitirFechasPasadas { get; set; }
        public bool PercepcionSinMontoMinimo { get; set; }

        public virtual Impuesto IdimpuestoNavigation { get; set; } = null!;
        public virtual Sucursal IdsucursalNavigation { get; set; } = null!;
        public virtual TipoComprobantePago IdtipoComprobantePagoNavigation { get; set; } = null!;
        public virtual ActivoFijoTipoCpActivoFijo ActivoFijoTipoCpActivoFijo { get; set; } = null!;
        public virtual TipoCanjeLetra TipoCanjeLetra { get; set; } = null!;
        public virtual TipoCargoCobranza TipoCargoCobranza { get; set; } = null!;
        public virtual TipoConciliacionBancarium TipoConciliacionBancarium { get; set; } = null!;
        public virtual TipoConfirmacionMedioDePago TipoConfirmacionMedioDePago { get; set; } = null!;
        public virtual TipoConsolidadoCarga TipoConsolidadoCarga { get; set; } = null!;
        public virtual TipoConsolidadoOrdenesCompra TipoConsolidadoOrdenesCompra { get; set; } = null!;
        public virtual TipoCotizacion TipoCotizacion { get; set; } = null!;
        public virtual TipoCpCaja TipoCpCaja { get; set; } = null!;
        public virtual TipoCpCompra TipoCpCompra { get; set; } = null!;
        public virtual TipoCpConteo TipoCpConteo { get; set; } = null!;
        public virtual TipoCpImportacion TipoCpImportacion { get; set; } = null!;
        public virtual TipoCpInvent TipoCpInvent { get; set; } = null!;
        public virtual TipoCpOrdenPago TipoCpOrdenPago { get; set; } = null!;
        public virtual TipoCpPercepcion TipoCpPercepcion { get; set; } = null!;
        public virtual TipoCpRetencion TipoCpRetencion { get; set; } = null!;
        public virtual TipoCpVentum TipoCpVentum { get; set; } = null!;
        public virtual TipoDua TipoDua { get; set; } = null!;
        public virtual TipoLetra TipoLetra { get; set; } = null!;
        public virtual TipoListaInventario TipoListaInventario { get; set; } = null!;
        public virtual TipoNotaCredito TipoNotaCredito { get; set; } = null!;
        public virtual TipoNotaDebito TipoNotaDebito { get; set; } = null!;
        public virtual TipoOrdenAnulacion TipoOrdenAnulacion { get; set; } = null!;
        public virtual TipoOrdenCompra TipoOrdenCompra { get; set; } = null!;
        public virtual TipoOrdenTransformacion TipoOrdenTransformacion { get; set; } = null!;
        public virtual TipoPedido TipoPedido { get; set; } = null!;
        public virtual TipoRequerimientoMercaderium TipoRequerimientoMercaderium { get; set; } = null!;
        public virtual TipoSolicitudCompra TipoSolicitudCompra { get; set; } = null!;
        public virtual TipoSolicitudCotizacion3 TipoSolicitudCotizacion3 { get; set; } = null!;
        public virtual TipoTomaInventario TipoTomaInventario { get; set; } = null!;
        public virtual TipoVoucher TipoVoucher { get; set; } = null!;
        public virtual ICollection<CanjeLetra> CanjeLetras { get; set; }
        public virtual ICollection<CargoCobranza> CargoCobranzas { get; set; }
        public virtual ICollection<ConfiguracionCierreApertura> ConfiguracionCierreAperturas { get; set; }
        public virtual ICollection<ConfiguracionConciliacionBancarium> ConfiguracionConciliacionBancariumIdtipoCpCajaEntradaNavigations { get; set; }
        public virtual ICollection<ConfiguracionConciliacionBancarium> ConfiguracionConciliacionBancariumIdtipoCpCajaSalidaNavigations { get; set; }
        public virtual ICollection<ConfiguracionConciliacionBancarium> ConfiguracionConciliacionBancariumIdtipoCpConfirmarMedioDePagoEmitidoNavigations { get; set; }
        public virtual ICollection<ConfiguracionConciliacionBancarium> ConfiguracionConciliacionBancariumIdtipoCpConfirmarMedioDePagoRecibidoNavigations { get; set; }
        public virtual ICollection<ConfiguracionConciliacionBancarium> ConfiguracionConciliacionBancariumIdtipoCpRechazarMedioDePagoEmitidoNavigations { get; set; }
        public virtual ICollection<ConfiguracionConciliacionBancarium> ConfiguracionConciliacionBancariumIdtipoCpRechazarMedioDePagoRecibidoNavigations { get; set; }
        public virtual ICollection<ConfiguracionDocCobrarPagar> ConfiguracionDocCobrarPagars { get; set; }
        public virtual ICollection<ConfiguracionTransferencium> ConfiguracionTransferencia { get; set; }
        public virtual ICollection<ConsolidadoCarga> ConsolidadoCargas { get; set; }
        public virtual ICollection<Cp> Cps { get; set; }
        public virtual ICollection<CptoOperacion> CptoOperacions { get; set; }
        public virtual ICollection<LiquidacionCaja> LiquidacionCajas { get; set; }
        public virtual ICollection<ListaInventario> ListaInventarios { get; set; }
        public virtual ICollection<VoucherContable> VoucherContables { get; set; }
    }
}
