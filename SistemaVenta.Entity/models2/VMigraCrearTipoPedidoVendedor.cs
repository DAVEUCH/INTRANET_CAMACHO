using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VMigraCrearTipoPedidoVendedor
    {
        public string? CodigoTipoPedido { get; set; }
        public string? Codigo { get; set; }
        public string? Nombre { get; set; }
        public string? ApPat { get; set; }
        public string? ApMat { get; set; }
        public string? Nomb1 { get; set; }
        public string? Nomb2 { get; set; }
        public bool? Activo { get; set; }
        public string? Cargo { get; set; }
        public string? EstCivil { get; set; }
        public string? Obse { get; set; }
        public string? Dni { get; set; }
        public string? Direc1 { get; set; }
        public string? Distr1 { get; set; }
        public string? Direc2 { get; set; }
        public string? TelefG { get; set; }
        public string? TelfC { get; set; }
        public string? Telefax { get; set; }
        public string? Grupoventa { get; set; }
        public int? Idvendedor { get; set; }
        public int? Idgrupo { get; set; }
    }
}
