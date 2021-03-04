using System;

namespace PaymentService.API.Models.Elavon {
    public class ElavonSummary {
        public string Id { get; set; }
        // Equals to `FileDate`
        public DateTime ReportDate { get; set; }
        // Equals to `Batch Reference` field in the file
        public string BatchNumber { get; set; }

        public DateTime BatchDate { get; set; }

        public MoneyAmount BatchAmount { get; set; }

        public string RoutingNumber { get; set; }

        public string BatchType { get; set; }

        public string AccountNumber { get; set; }

        public int DebitCount { get; set; }

        public MoneyAmount DebitAmount { get; set; }

        public MoneyAmount CreditAmount { get; set; }

        public int CreditCount { get; set; }

        public string ProcessorId { get; set; }
        public string SettlementReportId { get; set; }
    }
}
