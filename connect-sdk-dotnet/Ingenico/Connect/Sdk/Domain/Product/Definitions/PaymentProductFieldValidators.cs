/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
namespace Ingenico.Connect.Sdk.Domain.Product.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_PaymentProductFieldValidators">PaymentProductFieldValidators</a>
    /// </summary>
    public class PaymentProductFieldValidators
    {
        public EmptyValidator EmailAddress { get; set; } = null;

        public EmptyValidator ExpirationDate { get; set; } = null;

        public FixedListValidator FixedList { get; set; } = null;

        public LengthValidator Length { get; set; } = null;

        public EmptyValidator Luhn { get; set; } = null;

        public RangeValidator Range { get; set; } = null;

        public RegularExpressionValidator RegularExpression { get; set; } = null;
    }
}
