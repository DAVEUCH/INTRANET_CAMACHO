using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TmpTranfInven
    {
        public int RowNumber { get; set; }
        public int? EventClass { get; set; }
        public string? TextData { get; set; }
        public long? Duration { get; set; }
        public int? Spid { get; set; }
        public int? DatabaseId { get; set; }
        public string? DatabaseName { get; set; }
        public int? ObjectType { get; set; }
        public string? LoginName { get; set; }
        public byte[]? BinaryData { get; set; }
    }
}
