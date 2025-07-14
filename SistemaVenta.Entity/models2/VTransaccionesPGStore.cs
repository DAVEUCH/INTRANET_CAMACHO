using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VTransaccionesPGStore
    {
        public string? CustomerCode { get; set; }
        public string? CustomerName { get; set; }
        public string? SubcustomerCode { get; set; }
        public string? SubcustomerName { get; set; }
        public string? SubcustomerSalesrepZone { get; set; }
        public string? StoreCode { get; set; }
        public string? StoreName { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public string? LegalNumber { get; set; }
        public string StoreGeoAssocDataLevel1 { get; set; } = null!;
        public string? StoreGeoAssocDataLevel2 { get; set; }
        public string? StoreGeoAssocDataLevel3 { get; set; }
        public string? StoreGeoAssocDataLevel4 { get; set; }
        public string? StoreChannelAssocDataLevel1 { get; set; }
        public string? ZipCode { get; set; }
        public string Latitude { get; set; } = null!;
        public string Longitude { get; set; } = null!;
        public string StoreOwnerSegmentation { get; set; } = null!;
        public string GoldenStore { get; set; } = null!;
        public string LocalStoreClassification { get; set; } = null!;
        public string Attribute18 { get; set; } = null!;
        public bool Attribute19 { get; set; }
    }
}
