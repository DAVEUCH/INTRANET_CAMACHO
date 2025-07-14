using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Pbcatvld
    {
        public string PbvName { get; set; } = null!;
        public string? PbvVald { get; set; }
        public short? PbvType { get; set; }
        public int? PbvCntr { get; set; }
        public string? PbvMsg { get; set; }
    }
}
