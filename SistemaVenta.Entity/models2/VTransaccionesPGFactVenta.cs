using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VTransaccionesPGFactVenta
    {
        public string? FactNumber { get; set; }
        public string TransactionType { get; set; } = null!;
        public string? TransactionPeriod { get; set; }
        public string? CustomerCode { get; set; }
        public string? CustomerName { get; set; }
        public string? SubcustomerCode { get; set; }
        public string? SubcustomerName { get; set; }
        public string? StoreCode { get; set; }
        public string? StoreSalesrepCode { get; set; }
        public string? ProductGcasCode { get; set; }
        public string? ProductEan13Code { get; set; }
        public string? ProductDun14Code { get; set; }
        public string? ProductCustomerCode { get; set; }
        public decimal? IndirectShipmentsPu { get; set; }
        public int IndirectShipmentsCustomerUnits { get; set; }
        public decimal IndirectShipmentsAmount { get; set; }
        public DateTime FechaEmision { get; set; }
    }
}
