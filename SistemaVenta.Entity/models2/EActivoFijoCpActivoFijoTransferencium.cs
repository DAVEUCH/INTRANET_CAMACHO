using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EActivoFijoCpActivoFijoTransferencium
    {
        public int Id { get; set; }
        public int IdtipoCp { get; set; }
        public int Idpersona { get; set; }
        public int Idmoneda { get; set; }
        public int IdcptoOperacion { get; set; }
        public int Idperiodo { get; set; }
        public int Idsucursal { get; set; }
        public string IdtipoPersona { get; set; } = null!;
        public string IdtipoAsociado { get; set; } = null!;
        public int Idimpuesto { get; set; }
        public int IdlibroAuxiliar { get; set; }
        public int Idresponsable { get; set; }
        public int IdmotivoAnulacion { get; set; }
        public int IdvoucherContable { get; set; }
        public bool Anulado { get; set; }
        public bool Contabilizado { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaTipoCambio { get; set; }
        public decimal TipoCambio { get; set; }
        public DateTime Hora { get; set; }
        public bool Impreso { get; set; }
        public string NumCp { get; set; } = null!;
        public string Observacion { get; set; } = null!;
        public string? PersonaNombre { get; set; }
        public string NumCpContable { get; set; } = null!;
        public bool Preliminar { get; set; }
        public bool MonedaBase { get; set; }
        public bool Tercero { get; set; }
        public string NumeroVerificacion { get; set; } = null!;
        public decimal ValorAfecto { get; set; }
        public decimal ValorInafecto { get; set; }
        public decimal ValorVenta { get; set; }
        public decimal SubTotal { get; set; }
        public decimal ValorDescuento { get; set; }
        public decimal Total { get; set; }
        public bool TieneImpuesto { get; set; }
        public bool PreciosIncImpto { get; set; }
        public bool Administrativo { get; set; }
        public string RelacionTipoCpOrigen { get; set; } = null!;
        public string RelacionBalanceOrigenA { get; set; } = null!;
        public string RelacionBalanceOrigenB { get; set; } = null!;
        public string RelacionCardinalidad { get; set; } = null!;
        public string RelacionPropiedadReferencia { get; set; } = null!;
        public string RelacionPropiedadBalance { get; set; } = null!;
        public string RelacionTipoRelacion { get; set; } = null!;
        public int Idrelacion { get; set; }
        public int CpCobrarPagarId { get; set; }
        public int ActivoFijoCpActivoFijoTransferenciaCpInventarioSalidaId { get; set; }
        public int ActivoFijoCpActivoFijoTransferenciaCpInventarioSalidaIdcp { get; set; }
        public int ActivoFijoCpActivoFijoTransferenciaCpInventarioSalidaIdalmacen { get; set; }
        public int ActivoFijoCpActivoFijoTransferenciaCpInventarioSalidaMovStockContable { get; set; }
        public int ActivoFijoCpActivoFijoTransferenciaCpInventarioSalidaMovStockFisico { get; set; }
        public int ActivoFijoCpActivoFijoTransferenciaCpInventarioSalidaMovStockPorEntregar { get; set; }
        public int ActivoFijoCpActivoFijoTransferenciaCpInventarioSalidaMovStockPorRecibir { get; set; }
        public string ActivoFijoCpActivoFijoTransferenciaCpInventarioSalidaTipoCpInventario { get; set; } = null!;
        public decimal ActivoFijoCpActivoFijoTransferenciaCpInventarioSalidaPeso { get; set; }
        public decimal ActivoFijoCpActivoFijoTransferenciaCpInventarioSalidaVolumen { get; set; }
        public bool ActivoFijoCpActivoFijoTransferenciaCpInventarioSalidaSobregirarStockDisponible { get; set; }
        public int ActivoFijoCpActivoFijoTransferenciaCpActivoFijoEntradaId { get; set; }
        public int ActivoFijoCpActivoFijoTransferenciaTransferenciaCpActivoFijoEntradaIdcp { get; set; }
        public int ActivoFijoCpActivoFijoTransferenciaCpActivoFijoEntradaIdalmacen { get; set; }
        public int ActivoFijoCpActivoFijoTransferenciaCpActivoFijoEntradaMovStockContable { get; set; }
        public int ActivoFijoCpActivoFijoTransferenciaCpActivoFijoEntradaMovStockFisico { get; set; }
        public int ActivoFijoCpActivoFijoTransferenciaCpActivoFijoEntradaMovStockPorEntregar { get; set; }
        public int ActivoFijoCpActivoFijoTransferenciaCpActivoFijoEntradaMovStockPorRecibir { get; set; }
        public string ActivoFijoCpActivoFijoTransferenciaCpActivoFijoEntradaTipoCpInventario { get; set; } = null!;
        public decimal ActivoFijoCpActivoFijoTransferenciaCpActivoFijoEntradaPeso { get; set; }
        public decimal ActivoFijoCpActivoFijoTransferenciaCpActivoFijoEntradaVolumen { get; set; }
        public bool ActivoFijoCpActivoFijoTransferenciaCpActivoFijoEntradaSobregirarStockDisponible { get; set; }
        public bool ActivoFijoCpActivoFijoTransferenciaCpInventarioSalidaCostoPromedio { get; set; }
        public int ActivoFijoCpActivoFijoTransferenciaCpInventarioSalidaCostoPromedioCantidad { get; set; }
        public int ActivoFijoCpActivoFijoTransferenciaCpInventarioSalidaCostoPromedioMonto { get; set; }
        public bool ActivoFijoCpActivoFijoTransferenciaCpInventarioSalidaCostoUltimaCompra { get; set; }
        public bool ActivoFijoCpActivoFijoTransferenciaCpInventarioSalidaCostoReferencia { get; set; }
        public bool ActivoFijoCpActivoFijoTransferenciaCpInventarioSalidaCostoParalelo { get; set; }
        public int ActivoFijoCpActivoFijoTransferenciaCpInventarioSalidaIdtipoOperacion { get; set; }
        public bool ActivoFijoCpActivoFijoTransferenciaCpInventarioSalidaSugerenciaCompra { get; set; }
        public bool ActivoFijoCpActivoFijoTransferenciaCpActivoFijoEntradaCostoPromedio { get; set; }
        public int ActivoFijoCpActivoFijoTransferenciaCpActivoFijoEntradaCostoPromedioCantidad { get; set; }
        public int ActivoFijoCpActivoFijoTransferenciaCpActivoFijoEntradaCostoPromedioMonto { get; set; }
        public bool ActivoFijoCpActivoFijoTransferenciaCpActivoFijoEntradaCostoUltimaCompra { get; set; }
        public bool ActivoFijoCpActivoFijoTransferenciaCpActivoFijoEntradaCostoReferencia { get; set; }
        public bool ActivoFijoCpActivoFijoTransferenciaCpActivoFijoEntradaCostoParalelo { get; set; }
        public int ActivoFijoCpActivoFijoTransferenciaCpActivoFijoEntradaIdtipoOperacion { get; set; }
        public bool ActivoFijoCpActivoFijoTransferenciaCpActivoFijoEntradaSugerenciaCompra { get; set; }
        public bool Revisado { get; set; }
        public string? CpCobrarPagarNumeroDetraccion { get; set; }
        public DateTime? CpCobrarPagarFechaDetraccion { get; set; }
        public decimal AjusteImpuesto { get; set; }
        public int ActivoFijoCpActivoFijoTransferenciaPkid { get; set; }
        public string ActivoFijoCpActivoFijoTransferenciaNumDocOrigen { get; set; } = null!;
        public string ActivoFijoCpActivoFijoTransferenciaEstadoRecepcion { get; set; } = null!;
        public string ActivoFijoCpActivoFijoTransferenciaIdvehiculo { get; set; } = null!;
        public bool ActivoFijoCpActivoFijoTransferenciaRequiereTransportista { get; set; }
        public int ActivoFijoCpActivoFijoTransferenciaIdcpActivoFijoSalida { get; set; }
        public int ActivoFijoCpActivoFijoTransferenciaIdcpActivoFijoEntrada { get; set; }
        public string NumCpReferenciado { get; set; } = null!;
    }
}
