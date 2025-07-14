using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptInformacionPlanDeCuenta
    {
        public string PlanCuentasDescripcion { get; set; } = null!;
        public int PlanCuentasNiveles { get; set; }
        public string? PlanCuentasSegmento { get; set; }
        public int N1id { get; set; }
        public string? N1cuenta { get; set; }
        public string? N1descripcion { get; set; }
        public string? N1tipoCuenta { get; set; }
        public int? N1nivel { get; set; }
        public decimal? N1saldo { get; set; }
        public bool? N1esCaja { get; set; }
        public bool? N1esGastos { get; set; }
        public bool? N1esCuentaCorriente { get; set; }
        public bool? N1resumirEnLibroMayor { get; set; }
        public int N2id { get; set; }
        public string? N2cuenta { get; set; }
        public string? N2descripcion { get; set; }
        public string? N2tipoCuenta { get; set; }
        public int? N2nivel { get; set; }
        public decimal? N2saldo { get; set; }
        public bool? N2esCaja { get; set; }
        public bool? N2esGastos { get; set; }
        public bool? N2esCuentaCorriente { get; set; }
        public bool? N2resumirEnLibroMayor { get; set; }
        public int N3id { get; set; }
        public string? N3cuenta { get; set; }
        public string? N3descripcion { get; set; }
        public string? N3tipoCuenta { get; set; }
        public int? N3nivel { get; set; }
        public decimal? N3saldo { get; set; }
        public bool? N3esCaja { get; set; }
        public bool? N3esGatos { get; set; }
        public bool? N3esCuentaCorriente { get; set; }
        public bool? N3resumirEnLibroMayor { get; set; }
        public int N4id { get; set; }
        public string? N4cuenta { get; set; }
        public string? N4descripcion { get; set; }
        public string? N4tipoCuenta { get; set; }
        public int? N4nivel { get; set; }
        public decimal? N4saldo { get; set; }
        public bool? N4esCaja { get; set; }
        public bool? N4esGatos { get; set; }
        public bool? N4esCuentaCorriente { get; set; }
        public bool? N4resumirEnLibroMayor { get; set; }
        public int N5id { get; set; }
        public string? N5cuenta { get; set; }
        public string? N5descripcion { get; set; }
        public string? N5tipoCuenta { get; set; }
        public int? N5nivel { get; set; }
        public decimal? N5saldo { get; set; }
        public bool? N5esCaja { get; set; }
        public bool? N5esGastos { get; set; }
        public bool? N5esCuentaCorriente { get; set; }
        public int N5resumirEnLibroMayor { get; set; }
        public int N5monedaId { get; set; }
        public string N5monedaDescripcion { get; set; } = null!;
        public string N5monedaSimbolo { get; set; } = null!;
        public bool N5monedaEsBase { get; set; }
        public int N5transferenciaAbonoCuentaContableId { get; set; }
        public int N5transferenciaAbonoPorcentaje { get; set; }
        public string N5transferenciaAbonoCuentaContableCuenta { get; set; } = null!;
        public string N5transferenciaAbonoCuentaContableDescripcion { get; set; } = null!;
        public int N5transferenciaCargoCuentaId { get; set; }
        public int N5transferenciaCargoPorcentaje { get; set; }
        public string N5transferenciaCargoCuentaContableCuenta { get; set; } = null!;
        public string N5transferenciaCargoCuentaContableDescripcion { get; set; } = null!;
    }
}
