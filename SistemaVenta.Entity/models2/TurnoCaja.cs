using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TurnoCaja
    {
        public TurnoCaja()
        {
            ItemTurnoCajas = new HashSet<ItemTurnoCaja>();
        }

        public int Pkid { get; set; }
        public int Idcaja { get; set; }
        public int Idresponsable { get; set; }
        public DateTime Fecha { get; set; }
        public string Hora { get; set; } = null!;
        public bool Cerrado { get; set; }
        public string HoraCierre { get; set; } = null!;

        public virtual Persona IdresponsableNavigation { get; set; } = null!;
        public virtual ICollection<ItemTurnoCaja> ItemTurnoCajas { get; set; }
    }
}
