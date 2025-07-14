using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EConfiguracionDocCobrarPagar
    {
        public int Id { get; set; }
        public int IdcuentaContable { get; set; }
        public int IdcptoOperacion { get; set; }
        public int IdtipoCp { get; set; }
        public string Descripcion { get; set; } = null!;
    }
}
