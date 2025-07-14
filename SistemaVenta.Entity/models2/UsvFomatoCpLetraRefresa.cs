using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvFomatoCpLetraRefresa
    {
        public int CpLetraPkid { get; set; }
        public string CpLetraNumCp { get; set; } = null!;
        public string? CpDocCobrarPagarTipoCp { get; set; }
        public string? CpCanjeLetrasSucursal { get; set; }
        public DateTime CpLetraFechaEmision { get; set; }
        public DateTime CpLetraFechaVencimiento { get; set; }
        public decimal CpLetraTotal { get; set; }
        public string? CpTotalEnLetras { get; set; }
        public string CpLetraMoneda { get; set; } = null!;
        public string CpClienteNombre { get; set; } = null!;
        public string? CpClienteDocIdentidad { get; set; }
        public string? CpClienteTelefono { get; set; }
        public string CpClienteDireccion { get; set; } = null!;
        public string CpClienteLocalidad { get; set; } = null!;
    }
}
