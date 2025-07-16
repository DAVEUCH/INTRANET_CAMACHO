namespace SistemaVenta.AplicacionWeb.Models.ViewModels
{
    public class VMReposicionMarca
    {
        public int Row { get; set; }
        public string? CodigoMarca { get; set; }
        public string? Codigo { get; set; }
        public string? CodigoInterno { get; set; }
        public string? SEGCodigoMarca { get; set; }
        public decimal Puntuación_RFM { get; set; }
        public decimal SCORE_RFM { get; set; }
        public decimal SEG_RFM { get; set; }
        public int CantClien1 { get; set; }
        public string? Proveedor { get; set; }
        public string? Linea { get; set; }
        public string? Aplicacion { get; set; }
        public string? Unid { get; set; }
        public string? UltVta_Fec { get; set; }
        public int UltCant_ingreso { get; set; }
        public string? UltFec_Pedido { get; set; }
        public string? UltFec_ingreso { get; set; }
        public decimal MesesDemoraImpor { get; set; }
        public int UltCant_PorLlegar { get; set; }
        public string? Fec1er_PorLlegar { get; set; }
        public string? FecUlt_PorLlegar { get; set; }
        public string? FechaSinStock_PorLlegar { get; set; }
        public decimal MesesPromeDemoraImpor { get; set; }
        public decimal PromCantVtasMes { get; set; }
        public int TotVtas_2020_FRE { get; set; }
        public int TotVtas_2021_FRE { get; set; }
        public int TotVtas_2022_FRE { get; set; }
        public int TotVtas_2023_FRE { get; set; }
        public int TotVtas_2024_FRE { get; set; }
        public int TotVtas_2025_FRE { get; set; }
        public int TotVtas_2020_GCI { get; set; }
        public int TotVtas_2021_GCI { get; set; }
        public int TotVtas_2022_GCI { get; set; }
        public int TotVtas_2023_GCI { get; set; }
        public int TotVtas_2024_GCI { get; set; }
        public int TotVtas_2025_GCI { get; set; }
        public int TotVtas_Ult3Mes { get; set; }
        public int TotVtas_Ult6Mes { get; set; }
        public int TotVtas_Ult9Mes { get; set; }
        public int TotVtas_Ult12Mes { get; set; }
        public int Stock_GCI { get; set; }
        public int Stock_Freddy { get; set; }
        public int StockGrupo { get; set; }
        public int NumMesesComprar { get; set; }
        public int MesesConStock { get; set; }
        public int CantSugerida_aComprar { get; set; }
        public int CantAComprar_Confir { get; set; }
        public string? ProxPedido_FechaPide { get; set; }
        public string? ProxPedido_llega { get; set; }
        public int ProxPedido_Cant { get; set; }
        public decimal UltFOB_ingreso { get; set; }
        public decimal UtilBruta { get; set; }
        public int IDMarca { get; set; }

    }
}
