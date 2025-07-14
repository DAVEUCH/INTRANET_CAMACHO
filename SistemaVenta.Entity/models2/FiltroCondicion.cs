using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class FiltroCondicion
    {
        public string Pkid { get; set; } = null!;
        public string Idfiltro { get; set; } = null!;
        public string RutaCaracteristicaEstructural { get; set; } = null!;
        public string Condicion { get; set; } = null!;
        public string ValorSql { get; set; } = null!;
        public string Valor { get; set; } = null!;
        public string OperadorLogico { get; set; } = null!;
        public string RutaAtributoBusqueda { get; set; } = null!;

        public virtual Filtro IdfiltroNavigation { get; set; } = null!;
    }
}
