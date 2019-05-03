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
        public AdditionalOrderInput AdditionalInput { get; set; } = null;

        public AmountOfMoney AmountOfMoney { get; set; } = null;

        public Customer Customer { get; set; } = null;

        [ObsoleteAttribute("Use shoppingCart.items instead")]
        public IList<LineItem> Items { get; set; } = null;

        public OrderReferences References { get; set; } = null;

        [ObsoleteAttribute("Use Merchant.seller instead")]
        public Seller Seller { get; set; } = null;

        public Shipping Shipping { get; set; } = null;

        public ShoppingCart ShoppingCart { get; set; } = null;
    }
}
