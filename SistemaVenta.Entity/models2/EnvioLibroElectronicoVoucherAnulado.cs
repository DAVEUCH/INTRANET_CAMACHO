using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EnvioLibroElectronicoVoucherAnulado
    {
        public int IdvoucherContableResumen { get; set; }
        public string? NumCp { get; set; }
        public string? IdtipoCp { get; set; }
        public string? NumVoucher { get; set; }
        public int? Idperiodo { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Idcp { get; set; }
    }
}
