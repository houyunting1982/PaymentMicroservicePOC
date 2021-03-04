using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PaymentService.API.FakeData;
using PaymentService.API.Models;
using PaymentService.API.Models.Reconciliation;

namespace PaymentService.API.Controllers {
    /// <summary>
    /// The endpoints for fetching the reconciled settlement transactions
    /// </summary>
    [ApiController]
    [Produces("application/json", "text/plain")]
    [Route("api/[controller]")]
    public class ReconciliationsController : ControllerBase {
        /// <summary>
        /// Gets a list of reconciled settlement transactions, which are grouped by the <see cref="ReconciledReport"/> id.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET /api/reconciliations
        ///
        /// Sample response:
        ///
        ///     [
        ///         {
        ///             "id": "fdb01346-24cb-42d0-95b1-24a0c2743550",
        ///             "date": "2021-02-21T08:30:30Z",
        ///             "type": "tsys",
        ///             "transactions": [
        ///                 {
        ///                     "id": "72ec669e-ce34-4ece-b3c6-d32452c0a034",
        ///                     "reportId": "32f61a28-fb30-4d80-8470-4fef848109b4",
        ///                     "transactionId": "53ed790c-71c2-44c6-9c98-82da30316ce9",
        ///                    "transactionDate": "2021-02-20T03:30:30Z",
        ///                     "settlementNumber": "2345",
        ///                      "amount": {
        ///                         "value": "100.00",
        ///                         "code": "USD"
        ///                     },
        ///                     "authCode": "111AA1",
        ///                     "accountNumber": "5432",
        ///                     "paymentId": "6e5d195e-e4a1-41cc-b45b-1e87d3d7bfc6"
        ///                }
        ///            ]
        ///         }
        ///     ]
        ///
        /// </remarks>
        /// <param name="type">Settlement report provider type. (tsys|elavon|profitStars)</param>
        /// <param name="start">Start date</param>
        /// <param name="end">End date</param>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<List<ReconciledReport>> Get(string type, DateTime? start, DateTime? end) {
            var result = Stubs.ReconciledReports
                .Where(i => string.IsNullOrEmpty(type) || i.Type == type)
                .Where(i => !start.HasValue || i.Date > start.Value)
                .Where(i => !end.HasValue || i.Date < end.Value)
                .ToList();
            return Ok(result);
        }

        /// <summary>
        /// Gets a reconciled settlement transactions report by report Id.
        /// </summary>
        /// <remarks>
        ///
        /// Sample request:
        ///
        ///     GET /api/reconciliations/fdb01346-24cb-42d0-95b1-24a0c2743550
        ///
        /// Sample response:
        ///
        ///     {
        ///         "id": "fdb01346-24cb-42d0-95b1-24a0c2743550",
        ///         "date": "2021-02-21T08:30:30Z",
        ///         "type": "tsys",
        ///         "transactions": [
        ///             {
        ///                 "id": "72ec669e-ce34-4ece-b3c6-d32452c0a034",
        ///                "reportId": "32f61a28-fb30-4d80-8470-4fef848109b4",
        ///                 "transactionId": "53ed790c-71c2-44c6-9c98-82da30316ce9",
        ///                "transactionDate": "2021-02-20T03:30:30Z",
        ///                 "settlementNumber": "2345",
        ///                  "amount": {
        ///                     "value": "100.00",
        ///                     "code": "USD"
        ///                 },
        ///                 "authCode": "111AA1",
        ///                 "accountNumber": "5432",
        ///                 "paymentId": "6e5d195e-e4a1-41cc-b45b-1e87d3d7bfc6"
        ///            }
        ///        ]
        ///     }
        ///
        /// </remarks>
        /// <param name="id">Reconciled settlement report id</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<ReconciledReport> Get(string id) {
            var result = Stubs.ReconciledReports.SingleOrDefault(i => i.Id == id);
            return Ok(result);
        }
    }
}
