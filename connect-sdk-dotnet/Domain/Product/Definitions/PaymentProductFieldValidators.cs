/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Product.Definitions
{
    public class PaymentProductFieldValidators
    {
        public BoletoBancarioRequirednessValidator BoletoBancarioRequiredness { get; set; } = null;

        public EmptyValidator EmailAddress { get; set; } = null;

        public EmptyValidator ExpirationDate { get; set; } = null;

        public FixedListValidator FixedList { get; set; } = null;

        public EmptyValidator Iban { get; set; } = null;

        public LengthValidator Length { get; set; } = null;

        public EmptyValidator Luhn { get; set; } = null;

        public RangeValidator Range { get; set; } = null;

        public RegularExpressionValidator RegularExpression { get; set; } = null;

        public EmptyValidator ResidentIdNumber { get; set; } = null;

        public EmptyValidator TermsAndConditions { get; set; } = null;
    }
}
