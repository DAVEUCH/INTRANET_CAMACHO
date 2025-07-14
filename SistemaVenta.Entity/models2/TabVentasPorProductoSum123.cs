using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TabVentasPorProductoSum123
    {
        public int Idproducto { get; set; }
        public string Codigo { get; set; } = null!;
        public decimal? PromVtas { get; set; }
        public DateTime? UltVtaFec { get; set; }
        public decimal? TotVtas { get; set; }
        public int? Stock { get; set; }
        public int? UndVtaCalc { get; set; }
        public int UltCantIngreso1 { get; set; }
        public string UltFecIngreso1 { get; set; } = null!;
        public string UltFecPed1 { get; set; } = null!;
        public int CantVtas1 { get; set; }
        public int CantClien1 { get; set; }
        public int DiasDemoraImport1 { get; set; }
        public int DiasConStock1 { get; set; }
        public int MesesConStock1 { get; set; }
        public int DiasDemoraImport2 { get; set; }
        public int DiasConStock2 { get; set; }
        public int MesesConStock2 { get; set; }
        public int CantPorLlegar { get; set; }
        public string FecUltPedPorLlegar { get; set; } = null!;
        public string FecUltllegaPorLlegar { get; set; } = null!;
        public int DiasDemoraImportPorLlegar { get; set; }
        public int DiasConStockPorLlegar { get; set; }
        public int MesesConStockPorLlegar { get; set; }
        public int TotVtas2014Fre { get; set; }
        public int TotVtas2015Fre { get; set; }
        public int TotVtas2016Fre { get; set; }
        public int TotVtas2017Fre { get; set; }
        public int TotVtas2018Fre { get; set; }
        public int TotVtas2019Fre { get; set; }
        public int TotVtas2020Fre { get; set; }
        public int TotVtas2021Fre { get; set; }
        public int TotVtas2014Gci { get; set; }
        public int TotVtas2015Gci { get; set; }
        public int TotVtas2016Gci { get; set; }
        public int TotVtas2017Gci { get; set; }
        public int TotVtas2018Gci { get; set; }
        public int TotVtas2019Gci { get; set; }
        public int TotVtas2020Gci { get; set; }
        public int TotVtas2021Gci { get; set; }
        public int CalificaVtas { get; set; }
        public int? TotVtasUlt12Mes { get; set; }
        public int? TotVtasUlt9Mes { get; set; }
        public int? TotVtasUlt6Mes { get; set; }
        public int? TotVtasUlt3Mes { get; set; }
        public int DiasSinStock { get; set; }
        public int CantSugeridaAComprar { get; set; }
        public decimal? PromCantVtasMes { get; set; }
    }
}
