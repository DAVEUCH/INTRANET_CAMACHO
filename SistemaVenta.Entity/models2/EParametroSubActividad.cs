using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EParametroSubActividad
    {
        public string IdsubActividad { get; set; } = null!;
        public string ParametrosId { get; set; } = null!;
        public string ParametrosNombre { get; set; } = null!;
        public string ParametrosParametroTipo { get; set; } = null!;
        public string ParametrosIdvalorTipo { get; set; } = null!;
        public string ParametrosIdvalorObjetoDatos { get; set; } = null!;
        public string ParametrosIdvalorEnsamblado { get; set; } = null!;
        public string ParametrosValorClase { get; set; } = null!;
        public string ParametrosValorDiscreto { get; set; } = null!;
    }
}
