using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Cp
    {
        public Cp()
        {
            AsistenteNoDomiciliados = new HashSet<AsistenteNoDomiciliado>();
            CpCajas = new HashSet<CpCaja>();
            CpDescuentoRecargos = new HashSet<CpDescuentoRecargo>();
            CpInventarios = new HashSet<CpInventario>();
            CpRelacionadoIdcpNavigations = new HashSet<CpRelacionado>();
            CpRelacionadoIdcpRelacionadoNavigations = new HashSet<CpRelacionado>();
            DocCobrarPagars = new HashSet<DocCobrarPagar>();
            GastoConsolidadoCargas = new HashSet<GastoConsolidadoCarga>();
            ItemConciliacionBancariaDocumentos = new HashSet<ItemConciliacionBancariaDocumento>();
            ItemCps = new HashSet<ItemCp>();
            ItemTurnoCajas = new HashSet<ItemTurnoCaja>();
            PrestamoConsolidadoCargas = new HashSet<PrestamoConsolidadoCarga>();
            SalidaCajaPorGastosConsolidadoCargas = new HashSet<SalidaCajaPorGastosConsolidadoCarga>();
        }

        public int Pkid { get; set; }
        public int IdtipoCp { get; set; }
        public int Idpersona { get; set; }
        public int Idmoneda { get; set; }
        public int IdcptoOperacion { get; set; }
        public int Idperiodo { get; set; }
        public int Idsucursal { get; set; }
        public string IdtipoPersona { get; set; } = null!;
        public int IdmotivoAnulacion { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime Hora { get; set; }
        public bool Impreso { get; set; }
        public string NumCp { get; set; } = null!;
        public string NumCpContable { get; set; } = null!;
        public string Observacion { get; set; } = null!;
        public string? PersonaNombre { get; set; }
        public decimal Total { get; set; }
        public bool Anulado { get; set; }
        public bool Contabilizado { get; set; }
        public int IdvoucherContable { get; set; }
        public bool Preliminar { get; set; }
        public bool MonedaBase { get; set; }
        public bool Tercero { get; set; }
        public string NumeroVerificacion { get; set; } = null!;
        public int Idimpuesto { get; set; }
        public int IdlibroAuxiliar { get; set; }
        public int Idresponsable { get; set; }
        public decimal ValorAfecto { get; set; }
        public decimal ValorInafecto { get; set; }
        public decimal ValorVenta { get; set; }
        public decimal SubTotal { get; set; }
        public decimal ValorDescuento { get; set; }
        public bool TieneImpuesto { get; set; }
        public bool PreciosIncImpto { get; set; }
        public bool Administrativo { get; set; }
        public string IdtipoAsociado { get; set; } = null!;
        public decimal TipoCambio { get; set; }
        public DateTime FechaTipoCambio { get; set; }
        public bool Revisado { get; set; }
        public decimal AjusteImpuesto { get; set; }
        public string NumCpReferenciado { get; set; } = null!;
        public bool EvaluarPercepcion { get; set; }
        public bool EvaluarDetraccion { get; set; }
        public bool SumarPercepcionAlTotal { get; set; }
        public decimal MontoPercepcion { get; set; }
        public decimal MontoDetraccion { get; set; }

        public virtual CptoOperacion IdcptoOperacionNavigation { get; set; } = null!;
        public virtual Impuesto IdimpuestoNavigation { get; set; } = null!;
        public virtual LibroAuxiliar IdlibroAuxiliarNavigation { get; set; } = null!;
        public virtual Monedum IdmonedaNavigation { get; set; } = null!;
        public virtual Periodo IdperiodoNavigation { get; set; } = null!;
        public virtual Persona IdpersonaNavigation { get; set; } = null!;
        public virtual Persona IdresponsableNavigation { get; set; } = null!;
        public virtual Sucursal IdsucursalNavigation { get; set; } = null!;
        public virtual Clasificador IdtipoAsociadoNavigation { get; set; } = null!;
        public virtual TipoCp IdtipoCpNavigation { get; set; } = null!;
        public virtual ActivoFijoCpActivoFijoEntradum ActivoFijoCpActivoFijoEntradum { get; set; } = null!;
        public virtual ActivoFijoCpActivoFijoSalidum ActivoFijoCpActivoFijoSalidum { get; set; } = null!;
        public virtual ActivoFijoCpActivoFijoTransferencium ActivoFijoCpActivoFijoTransferencium { get; set; } = null!;
        public virtual CanjeLetra CanjeLetra { get; set; } = null!;
        public virtual Cotizacion Cotizacion { get; set; } = null!;
        public virtual Cotizacion3 Cotizacion3 { get; set; } = null!;
        public virtual CpCajaEntradum CpCajaEntradum { get; set; } = null!;
        public virtual CpCajaPago2 CpCajaPago2 { get; set; } = null!;
        public virtual CpCajaSalidum CpCajaSalidum { get; set; } = null!;
        public virtual CpCajaTransferencium CpCajaTransferencium { get; set; } = null!;
        public virtual CpCobrarPagar CpCobrarPagar { get; set; } = null!;
        public virtual CpCompra CpCompra { get; set; } = null!;
        public virtual CpConfirmarMedioPago CpConfirmarMedioPago { get; set; } = null!;
        public virtual CpConteo CpConteo { get; set; } = null!;
        public virtual CpDistribucion CpDistribucion { get; set; } = null!;
        public virtual CpImportacion CpImportacion { get; set; } = null!;
        public virtual CpImportacion2 CpImportacion2 { get; set; } = null!;
        public virtual CpInventarioEntradum CpInventarioEntradum { get; set; } = null!;
        public virtual CpInventarioSalidum CpInventarioSalidum { get; set; } = null!;
        public virtual CpInventarioTransferencium CpInventarioTransferencium { get; set; } = null!;
        public virtual CpRequerimientoCompra CpRequerimientoCompra { get; set; } = null!;
        public virtual CpRetencion CpRetencion { get; set; } = null!;
        public virtual CpVentum CpVentum { get; set; } = null!;
        public virtual Dua Dua { get; set; } = null!;
        public virtual Letra Letra { get; set; } = null!;
        public virtual NotaCredito NotaCredito { get; set; } = null!;
        public virtual NotaDebito NotaDebito { get; set; } = null!;
        public virtual OrdenCompra OrdenCompra { get; set; } = null!;
        public virtual OrdenTransformacion OrdenTransformacion { get; set; } = null!;
        public virtual Pedido Pedido { get; set; } = null!;
        public virtual Percepcion Percepcion { get; set; } = null!;
        public virtual Relacion Relacion { get; set; } = null!;
        public virtual RequerimientoMercaderium RequerimientoMercaderium { get; set; } = null!;
        public virtual SolicitudCompra SolicitudCompra { get; set; } = null!;
        public virtual SolicitudCotizacion3 SolicitudCotizacion3 { get; set; } = null!;
        public virtual ICollection<AsistenteNoDomiciliado> AsistenteNoDomiciliados { get; set; }
        public virtual ICollection<CpCaja> CpCajas { get; set; }
        public virtual ICollection<CpDescuentoRecargo> CpDescuentoRecargos { get; set; }
        public virtual ICollection<CpInventario> CpInventarios { get; set; }
        public virtual ICollection<CpRelacionado> CpRelacionadoIdcpNavigations { get; set; }
        public virtual ICollection<CpRelacionado> CpRelacionadoIdcpRelacionadoNavigations { get; set; }
        public virtual ICollection<DocCobrarPagar> DocCobrarPagars { get; set; }
        public virtual ICollection<GastoConsolidadoCarga> GastoConsolidadoCargas { get; set; }
        public virtual ICollection<ItemConciliacionBancariaDocumento> ItemConciliacionBancariaDocumentos { get; set; }
        public virtual ICollection<ItemCp> ItemCps { get; set; }
        public virtual ICollection<ItemTurnoCaja> ItemTurnoCajas { get; set; }
        public virtual ICollection<PrestamoConsolidadoCarga> PrestamoConsolidadoCargas { get; set; }
        public virtual ICollection<SalidaCajaPorGastosConsolidadoCarga> SalidaCajaPorGastosConsolidadoCargas { get; set; }
    }
}
