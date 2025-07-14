using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemEnvioLibroElectronicoDesvinculado
    {
        public int Pkid { get; set; }
        public int IdvoucherContableResumen { get; set; }
        public string? NumCp { get; set; }
        public string? IdtipoCp { get; set; }
        public string? NumVoucher { get; set; }
        public string? Idperiodo { get; set; }
        public DateTime? Fecha { get; set; }
    }
}
