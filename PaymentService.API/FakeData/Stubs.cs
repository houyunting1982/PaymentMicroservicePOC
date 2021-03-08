using System;
using System.Collections.Generic;
using PaymentService.API.Models;
using PaymentService.API.Models.Elavon;
using PaymentService.API.Models.Reconciliation;
using PaymentService.API.Models.TSYS;

namespace PaymentService.API.FakeData
{
    public static class Stubs
    {
        public static string TsysPaymentId_1 = "6e5d195e-e4a1-41cc-b45b-1e87d3d7bfc6";
        public static string TsysPaymentId_3 = "08ae0eb1-d2ce-4ce3-8c3c-441b5ab8de70";
        public static string TsysPaymentId_4 = "8ebb6a23-00c9-477b-a6f3-f09f63cfb31b";

        public static string TsysSummaryReportId_1 = "c068de30-5959-48fb-9522-aef06aabe8ef";
        public static string TsysSummaryReportId_2 = "f9edf16d-f57d-41c3-8b8f-98b270c30729";
        public static string TsysSummaryId_1 = "ed0f01d2-4144-4a47-8b82-0805133c3195";
        public static string TsysSummaryId_2 = "d303e53a-9815-4a7b-bb02-12ac1bbcbe07";
        public static string TsysSummaryId_3 = "6b3b2bf7-d5e9-4ffe-bdbd-5614c554aceb";

        public static string TsysTransactionReportId_1 = "32f61a28-fb30-4d80-8470-4fef848109b4";
        public static string TsysTransactionReportId_2 = "7126f459-4a8d-4a11-8e1a-3d396408d057";
        public static string TsysTransactionId_1_1 = "53ed790c-71c2-44c6-9c98-82da30316ce9";
        public static string TsysTransactionId_1_2 = "05ee7f8c-e102-42c9-997b-313f5f6e7de0";
        public static string TsysTransactionId_1_3 = "4e2c5f47-ac90-4c7c-aab9-4bc2a6943a72";
        public static string TsysTransactionId_2_1 = "5ba4f8ed-097f-47d4-a097-99e02b960980";
        public static string TsysTransactionId_2_2 = "ed4ee693-b8f4-4264-800d-f521eb6df65a";
        public static string TsysProcessorId = "839e42dd-4312-4245-8199-e47b73988844";

        public static string ElavonSummaryId_1 = "41282f53-3327-49ca-9814-57913cbd1798";
        public static string ElavonSummaryReportId = "c28f40e0-ee99-42d5-8bd7-79065d163ec7";
        public static string ElavonTransactionReportId = "804648e4-71de-4693-bc82-26816e7a8b92";
        public static string ElavonTransactionId_1 = "fdd36ab4-df04-4f32-a7db-f941d9aede85";
        public static string ElavonTransactionId_2 = "0887b08d-71b7-4bc9-9646-8e4b24a195d6";
        public static string ElavonProcessorId = "e163afcc-5ab5-487d-be61-0208a3f553f9";

        public static DateTime ReportDate = new DateTime(2021, 2, 21, 3, 30, 30, DateTimeKind.Utc);

        #region Imported Reports

        public static TSYSTransaction TsysTransaction1 = new TSYSTransaction {
            Id = TsysTransactionId_1_1,
            ReportDate = ReportDate,
            BatchNumber = "2345",
            TransactionDate = ReportDate.AddDays(-1),
            TransactionCode = "101",
            Amount = new MoneyAmount { Value = "100.00", Code = "USD" },
            AuthCode = "111AA1",
            Number = "5432",
            TransactionReferenceNumber = "Reference1234",
            TSYSSummaryId = TsysSummaryId_1,
            ProcessorId = TsysProcessorId,
            SettlementReportId = TsysTransactionReportId_1
        };

        public static TSYSTransaction TsysTransaction2 = new TSYSTransaction {
            Id = TsysTransactionId_1_2,
            ReportDate = ReportDate,
            BatchNumber = "2345",
            TransactionDate = ReportDate.AddHours(-12),
            TransactionCode = "101",
            Amount = new MoneyAmount { Value = "999.00", Code = "USD" },
            AuthCode = "123456",
            Number = "1113",
            TransactionReferenceNumber = "Reference1113",
            TSYSSummaryId = TsysSummaryId_1,
            ProcessorId = TsysProcessorId,
            SettlementReportId = TsysTransactionReportId_1
        };

        public static TSYSTransaction TsysTransaction3 = new TSYSTransaction {
            Id = TsysTransactionId_1_3,
            ReportDate = ReportDate,
            BatchNumber = "1111",
            TransactionDate = ReportDate.AddMinutes(-854),
            TransactionCode = "101",
            Amount = new MoneyAmount { Value = "19.95", Code = "USD" },
            AuthCode = "090909",
            Number = "9083",
            TransactionReferenceNumber = "Reference9083",
            TSYSSummaryId = TsysSummaryId_2,
            ProcessorId = TsysProcessorId,
            SettlementReportId = TsysTransactionReportId_1
        };

        public static TSYSTransaction TsysTransaction4 = new TSYSTransaction {
            Id = TsysTransactionId_2_1,
            ReportDate = ReportDate.AddDays(1),
            BatchNumber = "9999",
            TransactionDate = ReportDate.AddDays(1).AddMinutes(-854),
            TransactionCode = "102",
            Amount = new MoneyAmount { Value = "8000.00", Code = "USD" },
            AuthCode = "818520",
            Number = "9849",
            TransactionReferenceNumber = "Reference9849",
            TSYSSummaryId = TsysSummaryId_3,
            ProcessorId = TsysProcessorId,
            SettlementReportId = TsysTransactionReportId_2
        };

        public static TSYSTransaction TsysTransaction5 = new TSYSTransaction {
            Id = TsysTransactionId_2_2,
            ReportDate = ReportDate.AddDays(1),
            BatchNumber = "9999",
            TransactionDate = ReportDate.AddDays(1).AddMinutes(-854),
            TransactionCode = "102",
            Amount = new MoneyAmount { Value = "700.50", Code = "USD" },
            AuthCode = "12EDZD",
            Number = "0090",
            TransactionReferenceNumber = "Reference0090",
            TSYSSummaryId = TsysSummaryId_3,
            ProcessorId = TsysProcessorId,
            SettlementReportId = TsysTransactionReportId_2
        };

        public static TSYSSummary TsysSummary1 = new TSYSSummary {
            Id = TsysSummaryId_1,
            ReportDate = ReportDate,
            BatchNumber = "2345",
            BatchDate = ReportDate.Date,
            NetDepositAmount = new MoneyAmount { Value = "1099.00", Code = "USD" },
            HoldAmount = new MoneyAmount { Value = "0.00", Code = "USD" },
            AchAmount = new MoneyAmount { Value = "1099.00", Code = "USD" },
            AchDate = ReportDate.AddHours(-10),
            DebitCount = 2,
            DebitAmount = new MoneyAmount { Value = "1099.00", Code = "USD" },
            CreditCount = 0,
            CreditAmount = new MoneyAmount { Value = "0.00", Code = "USD" },
            ProcessorId = TsysProcessorId,
            SettlementReportId = TsysSummaryReportId_1
        };

        public static TSYSSummary TsysSummary2 = new TSYSSummary {
            Id = TsysSummaryId_1,
            ReportDate = ReportDate,
            BatchNumber = "1111",
            BatchDate = ReportDate.Date,
            NetDepositAmount = new MoneyAmount { Value = "19,95", Code = "USD" },
            HoldAmount = new MoneyAmount { Value = "0.00", Code = "USD" },
            AchAmount = new MoneyAmount { Value = "19,95", Code = "USD" },
            AchDate = ReportDate.AddHours(-10),
            DebitCount = 1,
            DebitAmount = new MoneyAmount { Value = "19,95", Code = "USD" },
            CreditCount = 0,
            CreditAmount = new MoneyAmount { Value = "0.00", Code = "USD" },
            ProcessorId = TsysProcessorId,
            SettlementReportId = TsysSummaryReportId_1
        };

        public static TSYSSummary TsysSummary3 = new TSYSSummary {
            Id = TsysSummaryId_3,
            ReportDate = ReportDate.AddDays(1),
            BatchNumber = "9999",
            BatchDate = ReportDate.AddDays(1).Date,
            NetDepositAmount = new MoneyAmount { Value = "8700.50", Code = "USD" },
            HoldAmount = new MoneyAmount { Value = "0.00", Code = "USD" },
            AchAmount = new MoneyAmount { Value = "8700.50", Code = "USD" },
            AchDate = ReportDate.AddDays(1).AddHours(-10),
            DebitCount = 2,
            DebitAmount = new MoneyAmount { Value = "8700.50", Code = "USD" },
            CreditCount = 0,
            CreditAmount = new MoneyAmount { Value = "0.00", Code = "USD" },
            ProcessorId = TsysProcessorId,
            SettlementReportId = TsysSummaryReportId_2
        };

        public static SettlementReport TsysSummaryReport_1 = new SettlementReport {
            Id = TsysSummaryReportId_1,
            Name = "batch summary 02-21-21.xlsx",
            ImportedAt = ReportDate.AddHours(5),
            Type = "tsys",
            Category = "summary",
            Data = new TSYSSummary[] { TsysSummary1, TsysSummary2 }
        };

        public static SettlementReport TsysSummaryReport_2 = new SettlementReport {
            Id = TsysSummaryReportId_1,
            Name = "batch summary 02-22-21.xlsx",
            ImportedAt = ReportDate.AddDays(1).AddHours(5),
            Type = "tsys",
            Category = "summary",
            Data = new TSYSSummary[] { TsysSummary3 }
        };

        public static SettlementReport TsysTransactionReport_1 = new SettlementReport {
            Id = TsysTransactionReportId_1,
            Name = "batch detail 02-21-21.xlsx",
            ImportedAt = ReportDate.AddHours(5),
            Type = "tsys",
            Category = "transaction",
            Data = new TSYSTransaction[] { TsysTransaction1, TsysTransaction2, TsysTransaction3 }
        };

        public static SettlementReport TsysTransactionReport_2 = new SettlementReport {
            Id = TsysTransactionReportId_1,
            Name = "batch detail 02-22-21.xlsx",
            ImportedAt = ReportDate.AddDays(1).AddHours(5),
            Type = "tsys",
            Category = "transaction",
            Data = new TSYSTransaction[] { TsysTransaction4, TsysTransaction5 }
        };

        public static ElavonTransaction ElavonTransaction1 = new ElavonTransaction {
            Id = ElavonTransactionId_1,
            ReportDate = ReportDate,
            BatchNumber = "99009900",
            TransactionDate = ReportDate.AddMinutes(-1854),
            Amount = new MoneyAmount { Value = "222.5", Code = "USD" },
            AuthCode = "777777",
            Number = "7654",
            TransactionReferenceNumber = "Reference7654",
            ElavonSummaryId = ElavonSummaryId_1,
            ProcessorId = ElavonProcessorId,
            SettlementReportId = ElavonTransactionReportId
        };

        public static ElavonTransaction ElavonTransaction2 = new ElavonTransaction {
            Id = ElavonTransactionId_2,
            ReportDate = ReportDate,
            BatchNumber = "99009900",
            TransactionDate = ReportDate.AddMinutes(-1854),
            Amount = new MoneyAmount { Value = "1222.5", Code = "USD" },
            AuthCode = "888777",
            Number = "8877",
            TransactionReferenceNumber = "Reference8877",
            ElavonSummaryId = ElavonSummaryId_1,
            ProcessorId = ElavonProcessorId,
            SettlementReportId = ElavonTransactionReportId
        };

        public static ElavonSummary ElavonSummary = new ElavonSummary {
            Id = ElavonSummaryId_1,
            ReportDate = ReportDate,
            BatchNumber = "99009900",
            BatchDate = ReportDate.Date,
            BatchAmount = new MoneyAmount { Value = "1445.00", Code = "USD" },
            RoutingNumber = "123456789",
            BatchType = "D",
            AccountNumber = "0210002111",
            DebitCount = 2,
            DebitAmount = new MoneyAmount { Value = "1445.00", Code = "USD" },
            CreditCount = 0,
            CreditAmount = new MoneyAmount { Value = "0.00", Code = "USD" },
            ProcessorId = ElavonProcessorId,
            SettlementReportId = ElavonSummaryReportId
        };

        public static SettlementReport ElavonTransactionReport = new SettlementReport {
            Id = ElavonTransactionReportId,
            Name = "017EN033313FUND20210221",
            ImportedAt = ReportDate.AddHours(9),
            Type = "elavon",
            Category = "transaction",
            Data = new ElavonTransaction[] { ElavonTransaction1, ElavonTransaction2 }
        };

        public static SettlementReport ElavontSummaryReport = new SettlementReport {
            Id = ElavonSummaryReportId,
            Name = "017EN033313FUND20210221",
            ImportedAt = ReportDate.AddHours(9),
            Type = "elavon",
            Category = "summary",
            Data = new ElavonSummary[] { ElavonSummary }
        };

        public static List<SettlementReport> Reports = new List<SettlementReport> {
            TsysTransactionReport_1,
            TsysSummaryReport_1,
            TsysTransactionReport_2,
            TsysSummaryReport_2,
            ElavonTransactionReport,
            ElavontSummaryReport
        };

        #endregion

        #region Reconciliation

        public static ReconciledTransaction ReconciledTransaction1 = new ReconciledTransaction {
            Id = "72ec669e-ce34-4ece-b3c6-d32452c0a034",
            ReportId = TsysTransactionReportId_1,
            TransactionId = TsysTransaction1.Id,
            TransactionDate = TsysTransaction1.TransactionDate,
            SettlementNumber = TsysTransaction1.BatchNumber,
            Amount = TsysTransaction1.Amount,
            AuthCode = TsysTransaction1.AuthCode,
            AccountNumber = TsysTransaction1.Number,
            PaymentId = TsysPaymentId_1
        };

        public static ReconciledTransaction ReconciledTransaction2 = new ReconciledTransaction {
            Id = "b26f4531-362d-4426-a508-155fd8bca313",
            ReportId = TsysTransactionReportId_1,
            TransactionId = TsysTransaction2.Id,
            TransactionDate = TsysTransaction2.TransactionDate,
            SettlementNumber = TsysTransaction2.BatchNumber,
            Amount = TsysTransaction2.Amount,
            AuthCode = TsysTransaction2.AuthCode,
            AccountNumber = TsysTransaction2.Number
        };

        public static ReconciledTransaction ReconciledTransaction3 = new ReconciledTransaction {
            Id = "23bd7893-f027-48a9-a4c7-c854ab8a42af",
            ReportId = TsysTransactionReportId_1,
            TransactionId = TsysTransaction3.Id,
            TransactionDate = TsysTransaction3.TransactionDate,
            SettlementNumber = TsysTransaction3.BatchNumber,
            Amount = TsysTransaction3.Amount,
            AuthCode = TsysTransaction3.AuthCode,
            AccountNumber = TsysTransaction3.Number,
            PaymentId = TsysPaymentId_3
        };

        public static ReconciledTransaction ReconciledTransaction4 = new ReconciledTransaction {
            Id = "a3ef6861-5130-4316-acfd-f836beabcb94",
            ReportId = TsysTransactionReportId_2,
            TransactionId = TsysTransaction4.Id,
            TransactionDate = TsysTransaction4.TransactionDate,
            SettlementNumber = TsysTransaction4.BatchNumber,
            Amount = TsysTransaction4.Amount,
            AuthCode = TsysTransaction4.AuthCode,
            AccountNumber = TsysTransaction4.Number,
            PaymentId = TsysPaymentId_4
        };

        public static ReconciledTransaction ReconciledTransaction5 = new ReconciledTransaction {
            Id = "1e1bda00-b3b2-477f-9a86-e9c599fded44",
            ReportId = TsysTransactionReportId_2,
            TransactionId = TsysTransaction5.Id,
            TransactionDate = TsysTransaction5.TransactionDate,
            SettlementNumber = TsysTransaction5.BatchNumber,
            Amount = TsysTransaction5.Amount,
            AuthCode = TsysTransaction5.AuthCode,
            AccountNumber = TsysTransaction5.Number,
        };


        public static ReconciledReport ReconciledReport_1 = new ReconciledReport {
            Id = "fdb01346-24cb-42d0-95b1-24a0c2743550",
            Date = ReportDate.AddHours(5),
            Type = "tsys",
            Transactions = new ReconciledTransaction[] { ReconciledTransaction1, ReconciledTransaction2, ReconciledTransaction3 }
        };

        public static ReconciledReport ReconciledReport_2 = new ReconciledReport {
            Id = "a9170451-1cae-404f-a993-cd225fa631ee",
            Date = ReportDate.AddDays(1).AddHours(5),
            Type = "tsys",
            Transactions = new ReconciledTransaction[] { ReconciledTransaction4, ReconciledTransaction5 }
        };

        public static List<ReconciledReport> ReconciledReports = new List<ReconciledReport> { ReconciledReport_1, ReconciledReport_2 };

        #endregion
    }
}
