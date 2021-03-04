using System;

namespace PaymentService.API.Models.Reconciliation
{
    public class ReconciledTransaction
    {
        public string Id { get; set; }
        public string ReportId { get; set; }
        public string TransactionId { get; set; }
        public DateTime TransactionDate { get; set; }
        public string SettlementNumber { get; set; }
        public MoneyAmount Amount { get; set; }
        public string AuthCode { get; set; }
        public string AccountNumber { get; set; }
        public string PaymentId { get; set; }
    }
}
