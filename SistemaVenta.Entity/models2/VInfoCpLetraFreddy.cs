using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VInfoCpLetraFreddy
    {
        public int CpLetraPkid { get; set; }
        public string CpLetraNumCp { get; set; } = null!;
        public string? CpDocCobrarPagarTipoCp { get; set; }
        public string CpCanjeLetrasSucursal { get; set; } = null!;
        public DateTime CpLetraFechaEmision { get; set; }
        public DateTime CpLetraFechaVencimiento { get; set; }
        public decimal CpLetraTotal { get; set; }
        public string? CpTotalEnLetras { get; set; }
        public bool CpLetraMoneda { get; set; }
        public string? CpClienteNombre { get; set; }
        public string? CpClienteDocIdentidad { get; set; }
        public string? CpClienteTelefono { get; set; }
        public string CpClienteDireccion { get; set; } = null!;
    }
}
