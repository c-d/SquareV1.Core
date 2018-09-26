using MeyerCorp.Square.V1.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MeyerCorp.Square.V1.Business
{
    public class CashDrawerShift
    {
        /// <summary>
        /// The shift's unique ID.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        string Id { get; set; }

        /// <summary>
        /// The shift's current state (OPEN, ENDED, or CLOSED).
        /// </summary>
        [JsonProperty(PropertyName = "cash_drawer_state")]
        public CashDrawerShiftState State { get; set; }

        /// <summary>
        /// The time when the shift began, in ISO 8601 format.
        /// </summary>
        [JsonProperty(PropertyName = "opened_at")]
        public DateTime Opened { get; set; }

        /// <summary>
        /// The time when the shift ended, in ISO 8601 format.
        /// </summary>
        [JsonProperty(PropertyName = "ended_at")]
        public DateTime Ended { get; set; }

        /// <summary>
        /// The time when the shift was closed, in ISO 8601 format.
        /// </summary>
        [JsonProperty(PropertyName = "closed_at")]
        public DateTime Closed { get; set; }

        /// <summary>
        /// The IDs of all employees that were logged into Square Point of Sale at some point during the cash drawer shift.
        /// </summary>
        [JsonProperty(PropertyName = "employee_ids")]
        public IEnumerable<string> EmployeeIds { get; set; }

        /// <summary>
        /// The ID of the employee that started the cash drawer shift.
        /// </summary>
        [JsonProperty(PropertyName = "opening_employee_id")]
        public string OpeningEmployeeId { get; set; }

        /// <summary>
        /// The ID of the employee that ended the cash drawer shift.
        /// </summary>
        [JsonProperty(PropertyName = "ending_employee_id")]
        public string EndingEmployeeId { get; set; }

        /// <summary>
        /// The ID of the employee that closed the cash drawer shift by auditing the cash drawer's contents.
        /// </summary>
        [JsonProperty(PropertyName = "closing_employee_id")]
        public string ClosingEmployeeId { get; set; }

        /// <summary>
        /// An optional description of the shift, entered by the employee that ended it.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// The amount of money in the cash drawer at the start of the shift.
        /// </summary>
        [JsonProperty(PropertyName = "starting_cash_money")]
        public Money StartingCashMoney { get; set; }

        /// <summary>
        /// The amount of money added to the cash drawer from cash payments.
        /// </summary>
        [JsonProperty(PropertyName = "cash_payment_money")]
        public Money CashPaymentMoney { get; set; }

        /// <summary>
        /// The amount of money removed from the cash drawer from cash refunds. This value is always negative or zero.
        /// </summary>
        [JsonProperty(PropertyName = "cash_refunds_money")]
        public Money CashRefundsMoney { get; set; }

        /// <summary>
        /// The amount of money added to the cash drawer for reasons other than cash payments.
        /// </summary>
        [JsonProperty(PropertyName = "cash_paid_in_money")]
        public Money CashPaidInMoney { get; set; }

        /// <summary>
        /// The amount of money removed from the cash drawer for reasons other than cash refunds.
        /// </summary>
        [JsonProperty(PropertyName = "cash_paid_out_money")]
        public Money CashPaidOutMoney { get; set; }

        /// <summary>
        /// The amount of money that should be in the cash drawer at the end of the shift, based on the shift's other money amounts.
        /// </summary>
        [JsonProperty(PropertyName = "expected_cash_money")]
        public Money ExpectedCashMoney { get; set; }

        /// <summary>
        /// The amount of money found in the cash drawer at the end of the shift by an auditing employee.
        /// </summary>
        [JsonProperty(PropertyName = "closed_cash_money")]
        public Money ClosedCashMoney { get; set; }

        /// <summary>
        /// The device running Square Point of Sale that was connected to the cash drawer.
        /// </summary>
        [JsonProperty(PropertyName = "device")]
        public Device Device { get; set; }

        /// <summary>
        /// All of the events (payments, refunds, and so on) that involved the cash drawer during the shift.  }
        /// </summary>
        [JsonProperty(PropertyName = "events")]
        public IEnumerable<CashDrawerEvent> Events { get; set; }
    }
}