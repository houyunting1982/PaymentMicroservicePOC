using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PaymentService.API.FakeData;
using PaymentService.API.Models;

namespace PaymentService.API.Controllers {
    /// <summary>
    /// The endpoints for fetching the parsed imported settlement reports
    /// </summary>
    [Produces("application/json", "text/plain")]
    [Route("api/[controller]")]
    public class ReportsController : ControllerBase {

        /// <summary>
        /// Gets a list of parsed imported settlement transactions, which are grouped by the <see cref="SettlementReport"/> id.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET /api/reports
        ///
        /// Sample response:
        ///
        ///     [
        ///       {
        ///         "id": "c068de30-5959-48fb-9522-aef06aabe8ef",
        ///         "name": "batch detail 02-21-21.xlsx",
        ///         "importedAt": "2021-02-21T08:30:30Z",
        ///         "type": "tsys",
        ///         "category": "transaction",
        ///         "data": [
        ///           {
        ///             "id": "53ed790c-71c2-44c6-9c98-82da30316ce9",
        ///             "reportDate": "2021-02-21T03:30:30Z",
        ///             "batchNumber": "2345",
        ///             "transactionDate": "2021-02-20T03:30:30Z",
        ///             "transactionCode": "101",
        ///             "amount": {
        ///               "value": "100.00",
        ///               "code": "USD"
        ///             },
        ///             "authCode": "111AA1",
        ///             "number": "5432",
        ///             "transactionReferenceNumber": "Reference1234",
        ///             "tsysSummaryId": "ed0f01d2-4144-4a47-8b82-0805133c3195",
        ///             "processorId": "839e42dd-4312-4245-8199-e47b73988844",
        ///             "settlementReportId": "32f61a28-fb30-4d80-8470-4fef848109b4"
        ///           },
        ///           {
        ///             "id": "05ee7f8c-e102-42c9-997b-313f5f6e7de0",
        ///             "reportDate": "2021-02-21T03:30:30Z",
        ///             "batchNumber": "2345",
        ///             "transactionDate": "2021-02-20T15:30:30Z",
        ///             "transactionCode": "101",
        ///             "amount": {
        ///               "value": "999.00",
        ///               "code": "USD"
        ///             },
        ///             "authCode": "123456",
        ///             "number": "1113",
        ///             "transactionReferenceNumber": "Reference1113",
        ///             "tsysSummaryId": "ed0f01d2-4144-4a47-8b82-0805133c3195",
        ///             "processorId": "839e42dd-4312-4245-8199-e47b73988844",
        ///             "settlementReportId": "32f61a28-fb30-4d80-8470-4fef848109b4"
        ///           },
        ///           {
        ///             "id": "4e2c5f47-ac90-4c7c-aab9-4bc2a6943a72",
        ///             "reportDate": "2021-02-21T03:30:30Z",
        ///             "batchNumber": "1111",
        ///             "transactionDate": "2021-02-20T13:16:30Z",
        ///             "transactionCode": "101",
        ///             "amount": {
        ///               "value": "19.95",
        ///               "code": "USD"
        ///             },
        ///             "authCode": "090909",
        ///             "number": "9083",
        ///             "transactionReferenceNumber": "Reference9083",
        ///             "tsysSummaryId": "d303e53a-9815-4a7b-bb02-12ac1bbcbe07",
        ///             "processorId": "839e42dd-4312-4245-8199-e47b73988844",
        ///             "settlementReportId": "32f61a28-fb30-4d80-8470-4fef848109b4"
        ///           }
        ///         ]
        ///       }
        ///     ]
        /// </remarks>
        /// <param name="category">Settlement report type (summary|transaction)</param>
        /// <param name="type">Settlement report provider type. (tsys|elavon|profitStars)</param>
        /// <param name="start">Start date</param>
        /// <param name="end">End date</param>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<List<SettlementReport>> Get(string type, string category, DateTime? start, DateTime? end) {
            var result = Stubs.Reports
                .Where(i => string.IsNullOrEmpty(type) || i.Type == type)
                .Where(i => string.IsNullOrEmpty(category) || i.Category == category)
                .Where(i => !start.HasValue || i.ImportedAt > start.Value)
                .Where(i => !end.HasValue || i.ImportedAt < end.Value)
                .ToList();
            return Ok(result);
        }

        /// <summary>
        /// Gets parsed imported settlement transactions by report id
        /// </summary>
        /// <remarks>
        ///
        /// Sample request:
        ///
        ///     GET /api/report/c068de30-5959-48fb-9522-aef06aabe8ef
        ///
        /// Sample response:
        /// 
        ///      {
        ///           "id": "c068de30-5959-48fb-9522-aef06aabe8ef",
        ///           "name": "batch summary 02-21-21.xlsx",
        ///           "importedAt": "2021-02-21T08:30:30Z",
        ///           "type": "tsys",
        ///           "category": "summary",
        ///           "data": [
        ///           {
        ///               "id": "ed0f01d2-4144-4a47-8b82-0805133c3195",
        ///               "reportDate": "2021-02-21T03:30:30Z",
        ///               "batchNumber": "2345",
        ///               "batchDate": "2021-02-21T00:00:00Z",
        ///               "netDepositAmount": {
        ///                   "value": "1099.00",
        ///                   "code": "USD"
        ///               },
        ///               "holdAmount": {
        ///                   "value": "0.00",
        ///                   "code": "USD"
        ///               },
        ///               "achAmount": {
        ///                   "value": "1099.00",
        ///                   "code": "USD"
        ///               },
        ///               "achDate": "2021-02-20T17:30:30Z",
        ///               "debitCount": 2,
        ///               "debitAmount": {
        ///                   "value": "1099.00",
        ///                   "code": "USD"
        ///               },
        ///               "creditCount": 0,
        ///               "creditAmount": {
        ///                   "value": "0.00",
        ///                   "code": "USD"
        ///               },
        ///               "processorId": "839e42dd-4312-4245-8199-e47b73988844",
        ///               "settlementReportId": "c068de30-5959-48fb-9522-aef06aabe8ef"
        ///           },
        ///           {
        ///               "id": "ed0f01d2-4144-4a47-8b82-0805133c3195",
        ///               "reportDate": "2021-02-21T03:30:30Z",
        ///               "batchNumber": "1111",
        ///               "batchDate": "2021-02-21T00:00:00Z",
        ///               "netDepositAmount": {
        ///                   "value": "19,95",
        ///                   "code": "USD"
        ///               },
        ///               "holdAmount": {
        ///                   "value": "0.00",
        ///                   "code": "USD"
        ///               },
        ///               "achAmount": {
        ///                   "value": "19,95",
        ///                   "code": "USD"
        ///               },
        ///               "achDate": "2021-02-20T17:30:30Z",
        ///               "debitCount": 1,
        ///               "debitAmount": {
        ///                   "value": "19,95",
        ///                   "code": "USD"
        ///               },
        ///               "creditCount": 0,
        ///               "creditAmount": {
        ///                   "value": "0.00",
        ///                   "code": "USD"
        ///               },
        ///               "processorId": "839e42dd-4312-4245-8199-e47b73988844",
        ///               "settlementReportId": "c068de30-5959-48fb-9522-aef06aabe8ef"
        ///           }
        ///           ]
        ///      }
        ///
        /// </remarks>
        /// <param name="id">Settlement report id</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<SettlementReport> Get(string id) {
            var result = Stubs.Reports.SingleOrDefault(i => i.Id == id);
            return Ok(result);
        }
    }
}
