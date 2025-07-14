using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenta.Entity.Models
{
    public partial class Asignado
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Descriptione { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
