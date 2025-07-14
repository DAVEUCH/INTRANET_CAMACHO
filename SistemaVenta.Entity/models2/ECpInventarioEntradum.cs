using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ECpInventarioEntradum
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
        public int CpInventarioEntradaPkid { get; set; }
        public int CpInventarioEntradaIdcpInventario { get; set; }
        public string CpInventarioEntradaEstadoFacturacion { get; set; } = null!;
        public string CpInventarioEntradaEstadoDevolucion { get; set; } = null!;
        public string CpInventarioEntradaNumDocOrigen { get; set; } = null!;
        public bool CpInventarioEntradaImportacion { get; set; }
        public string? CpInventarioEntradaEstadoNacionalizacion { get; set; }
        public int CpInventarioEntradaCpInventarioId { get; set; }
        public int CpInventarioEntradaCpInventarioIdalmacen { get; set; }
        public int CpInventarioEntradaCpInventarioIdtipoOperacion { get; set; }
        public int CpInventarioEntradaCpInventarioMovStockContable { get; set; }
        public int CpInventarioEntradaCpInventarioMovStockFisico { get; set; }
        public int CpInventarioEntradaCpInventarioMovStockPorEntregar { get; set; }
        public int CpInventarioEntradaCpInventarioMovStockPorRecibir { get; set; }
        public string CpInventarioEntradaCpInventarioTipoCpInventario { get; set; } = null!;
        public decimal CpInventarioEntradaCpInventarioPeso { get; set; }
        public decimal CpInventarioEntradaCpInventarioVolumen { get; set; }
        public bool CpInventarioEntradaCpInventarioSobregirarStockDisponible { get; set; }
        public bool CpInventarioEntradaCpInventarioCostoPromedio { get; set; }
        public int CpInventarioEntradaCpInventarioCostoPromedioCantidad { get; set; }
        public int CpInventarioEntradaCpInventarioCostoPromedioMonto { get; set; }
        public bool CpInventarioEntradaCpInventarioCostoUltimaCompra { get; set; }
        public bool CpInventarioEntradaCpInventarioCostoReferencia { get; set; }
        public bool CpInventarioEntradaCpInventarioCostoParalelo { get; set; }
        public bool CpInventarioEntradaCpInventarioSugerenciaCompra { get; set; }
        public bool Revisado { get; set; }
        public string? CpCobrarPagarNumeroDetraccion { get; set; }
        public DateTime? CpCobrarPagarFechaDetraccion { get; set; }
        public decimal AjusteImpuesto { get; set; }
        public DateTime? CpCobrarPagarFechaPago { get; set; }
        public string NumCpReferenciado { get; set; } = null!;
        public string CpInventarioEntradaEstadoSalida { get; set; } = null!;
        public bool EvaluarPercepcion { get; set; }
        public bool EvaluarDetraccion { get; set; }
        public bool SumarPercepcionAlTotal { get; set; }
        public decimal MontoPercepcion { get; set; }
        public decimal MontoDetraccion { get; set; }
    }
}
