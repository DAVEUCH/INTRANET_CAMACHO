using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VTransaccionesPGProduct
    {
        public string? ProductGcasCode { get; set; }
        public string? ProductEan13Code { get; set; }
        public string? ProductCustomerCode { get; set; }
        public string? CustomerCode { get; set; }
        public string? CustomerName { get; set; }
        public string? SubcustomerCode { get; set; }
        public string? SubcustomerName { get; set; }
        public string? ProductName { get; set; }
        public int? ProductPcxcases { get; set; }
        public string? ProductDun14 { get; set; }
    }
}
