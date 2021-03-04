using System;

namespace PaymentService.API.Models.Reconciliation
{
    public class ReconciledReport
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public ReconciledTransaction[] Transactions { get; set; }
    }
}
