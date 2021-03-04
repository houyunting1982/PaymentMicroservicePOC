using System;

namespace PaymentService.API.Models.TSYS {
    public class TSYSTransaction {
        public string Id { get; set; }

        // Equals to `FileDate` in the file
        public DateTime ReportDate { get; set; }

        public string BatchNumber { get; set; }

        public DateTime TransactionDate { get; set; }

        public string TransactionCode { get; set; }

        public MoneyAmount Amount { get; set; }

        public string AuthCode { get; set; }

        public string Number { get; set; }

        public string TransactionReferenceNumber { get; set; }

        public string TSYSSummaryId { get; set; }

        public string ProcessorId { get; set; }

        public string SettlementReportId { get; set; }

    }
}
