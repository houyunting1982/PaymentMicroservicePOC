using System;

namespace PaymentService.API.Models.TSYS {
    public class TSYSSummary {
        public string Id { get; set; }
        // Equals to `FileDate` in the file
        public DateTime ReportDate { get; set; }

        public string BatchNumber { get; set; }

        public DateTime BatchDate { get; set; }

        public MoneyAmount NetDepositAmount { get; set; }

        public MoneyAmount HoldAmount { get; set; }

        public MoneyAmount AchAmount { get; set; }

        public DateTime AchDate { get; set; }

        public int DebitCount { get; set; }

        public MoneyAmount DebitAmount { get; set; }

        public int CreditCount { get; set; }

        public MoneyAmount CreditAmount { get; set; }

        public string ProcessorId { get; set; }

        public string SettlementReportId { get; set; }
    }
}
