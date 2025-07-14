using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EActivoFijoCpActivoFijoSalidum
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
        public int ActivoFijoCpActivoFijoSalidaCpInventarioId { get; set; }
        public int ActivoFijoCpActivoFijoSalidaCpInventarioIdalmacen { get; set; }
        public int ActivoFijoCpActivoFijoSalidaCpInventarioIdtipoOperacion { get; set; }
        public int ActivoFijoCpActivoFijoSalidaCpInventarioMovStockContable { get; set; }
        public int ActivoFijoCpActivoFijoSalidaCpInventarioMovStockFisico { get; set; }
        public int ActivoFijoCpActivoFijoSalidaCpInventarioMovStockPorEntregar { get; set; }
        public int ActivoFijoCpActivoFijoSalidaCpInventarioMovStockPorRecibir { get; set; }
        public string ActivoFijoCpActivoFijoSalidaCpInventarioTipoCpInventario { get; set; } = null!;
        public decimal ActivoFijoCpActivoFijoSalidaCpInventarioPeso { get; set; }
        public decimal ActivoFijoCpActivoFijoSalidaCpInventarioVolumen { get; set; }
        public bool ActivoFijoCpActivoFijoSalidaCpInventarioSobregirarStockDisponible { get; set; }
        public bool ActivoFijoCpActivoFijoSalidaCpInventarioCostoPromedio { get; set; }
        public int ActivoFijoCpActivoFijoSalidaCpInventarioCostoPromedioCantidad { get; set; }
        public int ActivoFijoCpActivoFijoSalidaCpInventarioCostoPromedioMonto { get; set; }
        public bool ActivoFijoCpActivoFijoSalidaCpInventarioCostoUltimaCompra { get; set; }
        public bool ActivoFijoCpActivoFijoSalidaCpInventarioCostoReferencia { get; set; }
        public bool ActivoFijoCpActivoFijoSalidaCpInventarioCostoParalelo { get; set; }
        public bool ActivoFijoCpActivoFijoSalidaCpInventarioSugerenciaCompra { get; set; }
        public bool Revisado { get; set; }
        public string? CpCobrarPagarNumeroDetraccion { get; set; }
        public DateTime? CpCobrarPagarFechaDetraccion { get; set; }
        public decimal AjusteImpuesto { get; set; }
        public int ActivoFijoCpActivoFijoSalidaPkid { get; set; }
        public int ActivoFijoCpActivoFijoSalidaIdcpInventario { get; set; }
        public string ActivoFijoCpActivoFijoSalidaEstadoFacturacion { get; set; } = null!;
        public string ActivoFijoCpActivoFijoSalidaEstadoDevolucion { get; set; } = null!;
        public string ActivoFijoCpActivoFijoSalidaNumeroOrdenCompra { get; set; } = null!;
        public string ActivoFijoCpActivoFijoSalidaDireccionEntrega { get; set; } = null!;
        public int ActivoFijoCpActivoFijoSalidaIdvehiculo { get; set; }
        public bool ActivoFijoCpActivoFijoSalidaRequiereTransportista { get; set; }
        public string ActivoFijoCpActivoFijoSalidaEstadoEntregaDevolucion { get; set; } = null!;
        public int ActivoFijoCpActivoFijoSalidaIdvehiculo2 { get; set; }
        public string ActivoFijoCpActivoFijoSalidaDireccionTransportista { get; set; } = null!;
        public string ActivoFijoCpActivoFijoSalidaDireccionTransportista2 { get; set; } = null!;
        public string NumCpReferenciado { get; set; } = null!;
    }
}
