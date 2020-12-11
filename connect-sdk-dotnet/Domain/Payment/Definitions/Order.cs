/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;
using System;
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class Order
    {
        /// <summary>
        /// Object containing additional input on the order
        /// </summary>
        public AdditionalOrderInput AdditionalInput { get; set; } = null;

        /// <summary>
        /// Object containing amount and ISO currency code attributes
        /// </summary>
        public AmountOfMoney AmountOfMoney { get; set; } = null;

        /// <summary>
        /// Object containing the details of the customer
        /// </summary>
        public Customer Customer { get; set; } = null;

        /// <summary>
        /// Shopping cart data
        /// </summary>
        [ObsoleteAttribute("Use shoppingCart.items instead")]
        public IList<LineItem> Items { get; set; } = null;

        /// <summary>
        /// Object that holds all reference properties that are linked to this transaction
        /// </summary>
        public OrderReferences References { get; set; } = null;

        /// <summary>
        /// Object containing seller details
        /// </summary>
        [ObsoleteAttribute("Use Merchant.seller instead")]
        public Seller Seller { get; set; } = null;

        /// <summary>
        /// Object containing information regarding shipping / delivery
        /// </summary>
        public Shipping Shipping { get; set; } = null;

        /// <summary>
        /// Shopping cart data, including items and specific amounts.
        /// </summary>
        public ShoppingCart ShoppingCart { get; set; } = null;
    }
}
