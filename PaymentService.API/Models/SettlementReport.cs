using System;

namespace PaymentService.API.Models {
    public class SettlementReport {
        public string Id { get; set; }

        public string Name { get; set; }

        public DateTime ImportedAt { get; set; }

        public string Type { get; set; }

        public string Category { get; set; }

        public object Data { get; set; }
    }
}
