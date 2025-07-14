using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EActivoFijoCpActivoFijoEntradum
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
        public int ActivoFijoCpActivoFijoEntradaCpInventarioId { get; set; }
        public int ActivoFijoCpActivoFijoEntradaCpInventarioIdalmacen { get; set; }
        public int ActivoFijoCpActivoFijoEntradaCpInventarioIdtipoOperacion { get; set; }
        public int ActivoFijoCpActivoFijoEntradaCpInventarioMovStockContable { get; set; }
        public int ActivoFijoCpActivoFijoEntradaCpInventarioMovStockFisico { get; set; }
        public int ActivoFijoCpActivoFijoEntradaCpInventarioMovStockPorEntregar { get; set; }
        public int ActivoFijoCpActivoFijoEntradaCpInventarioMovStockPorRecibir { get; set; }
        public string ActivoFijoCpActivoFijoEntradaCpInventarioTipoCpInventario { get; set; } = null!;
        public decimal ActivoFijoCpActivoFijoEntradaCpInventarioPeso { get; set; }
        public decimal ActivoFijoCpActivoFijoEntradaCpInventarioVolumen { get; set; }
        public bool ActivoFijoCpActivoFijoEntradaCpInventarioSobregirarStockDisponible { get; set; }
        public bool ActivoFijoCpActivoFijoEntradaCpInventarioCostoPromedio { get; set; }
        public int ActivoFijoCpActivoFijoEntradaCpInventarioCostoPromedioCantidad { get; set; }
        public int ActivoFijoCpActivoFijoEntradaCpInventarioCostoPromedioMonto { get; set; }
        public bool ActivoFijoCpActivoFijoEntradaCpInventarioCostoUltimaCompra { get; set; }
        public bool ActivoFijoCpActivoFijoEntradaCpInventarioCostoReferencia { get; set; }
        public bool ActivoFijoCpActivoFijoEntradaCpInventarioCostoParalelo { get; set; }
        public bool ActivoFijoCpActivoFijoEntradaCpInventarioSugerenciaCompra { get; set; }
        public bool Revisado { get; set; }
        public string? CpCobrarPagarNumeroDetraccion { get; set; }
        public DateTime? CpCobrarPagarFechaDetraccion { get; set; }
        public decimal AjusteImpuesto { get; set; }
        public int ActivoFijoCpActivoFijoEntradaPkid { get; set; }
        public int ActivoFijoCpActivoFijoEntradaIdcpInventario { get; set; }
        public string ActivoFijoCpActivoFijoEntradaEstadoFacturacion { get; set; } = null!;
        public string ActivoFijoCpActivoFijoEntradaEstadoDevolucion { get; set; } = null!;
        public string ActivoFijoCpActivoFijoEntradaNumDocOrigen { get; set; } = null!;
        public string? ActivoFijoCpActivoFijoEntradaEstadoNacionalizacion { get; set; }
        public bool ActivoFijoCpActivoFijoEntradaImportacion { get; set; }
        public string NumCpReferenciado { get; set; } = null!;
    }
}
