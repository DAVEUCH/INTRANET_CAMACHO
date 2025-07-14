using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EConfiguracionTransferencium
    {
        public int Id { get; set; }
        public int IdcptoOperacion { get; set; }
        public int IdtipoCp { get; set; }
        public int Idresponsable { get; set; }
        public string Descripcion { get; set; } = null!;
        public bool RestringirConfiguracion { get; set; }
    }
}
