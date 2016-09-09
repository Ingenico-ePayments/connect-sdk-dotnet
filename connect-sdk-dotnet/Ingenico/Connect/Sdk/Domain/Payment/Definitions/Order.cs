/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_Order">Order</a>
    /// </summary>
    public class Order
    {
        public AdditionalOrderInput AdditionalInput { get; set; } = null;

        public AmountOfMoney AmountOfMoney { get; set; } = null;

        public Customer Customer { get; set; } = null;

        public IList<LineItem> Items { get; set; } = null;

        public OrderReferences References { get; set; } = null;
    }
}
