using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteLibroMayor
    {
        public string VoucherContableNumero { get; set; } = null!;
        public DateTime VoucherContableFecha { get; set; }
        public int VoucherContablePeriodoId { get; set; }
        public string VoucherContablePeriodoDescripcion { get; set; } = null!;
        public int VoucherContableEjercicioId { get; set; }
        public string VoucherContableComprobanteOrigenTipo { get; set; } = null!;
        public string VoucherContableComprobanteOrigenNumero { get; set; } = null!;
        public DateTime VoucherContableComprobanteOrigenFecha { get; set; }
        public string AsientoGlosa { get; set; } = null!;
        public string? CargoAbonoCuentaNumero { get; set; }
        public string? CargoAbonoCuentaDescripcion { get; set; }
        public string CargoAbonoGlosa { get; set; } = null!;
        public decimal CargoAbonoCargo { get; set; }
        public decimal CargoAbonoAbono { get; set; }
        public decimal? CargoAbonoSaldo { get; set; }
        public decimal CargoAbonoCargoMonedaBase { get; set; }
        public decimal CargoAbonoAbonoMonedaBase { get; set; }
        public decimal? CargoAbonoSaldoMonedaBase { get; set; }
        public int CargoAbonoMonedaId { get; set; }
        public bool? ResumirEnLibroMayor { get; set; }
        public string? CargoAbonoAuxiliarCodigo { get; set; }
        public string? CargoAbonoAuxiliarNombre { get; set; }
        public int? CargoAbonoAuxiliarId { get; set; }
        public int CargoAbonoCuentaContableId { get; set; }
    }
}
