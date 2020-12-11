/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Product.Definitions
{
    public class PaymentProductFieldValidators
    {
        /// <summary>
        /// Indicates the requiredness of the field based on the fiscalnumber for Boleto Bancario
        /// </summary>
        public BoletoBancarioRequirednessValidator BoletoBancarioRequiredness { get; set; } = null;

        /// <summary>
        /// Indicates that the content should be validated against the rules for an email address
        /// </summary>
        public EmptyValidator EmailAddress { get; set; } = null;

        /// <summary>
        /// Indicates that the content should be validated against the rules for an expiration date (it should be in the future)
        /// </summary>
        public EmptyValidator ExpirationDate { get; set; } = null;

        /// <summary>
        /// Indicates that content should be one of the, in this object, listed items
        /// </summary>
        public FixedListValidator FixedList { get; set; } = null;

        /// <summary>
        /// Indicates that the content of this (iban) field needs to validated against format checks and modulo check (as described in ISO 7064)
        /// </summary>
        public EmptyValidator Iban { get; set; } = null;

        /// <summary>
        /// Indicates that the content needs to be validated against length criteria defined in this object
        /// </summary>
        public LengthValidator Length { get; set; } = null;

        /// <summary>
        /// Indicates that the content needs to be validated using a LUHN check
        /// </summary>
        public EmptyValidator Luhn { get; set; } = null;

        /// <summary>
        /// Indicates that the content needs to be validated against a, in this object, defined range
        /// </summary>
        public RangeValidator Range { get; set; } = null;

        /// <summary>
        /// A string representing the regular expression to check
        /// </summary>
        public RegularExpressionValidator RegularExpression { get; set; } = null;

        /// <summary>
        /// Indicates that the content needs to be validated as per the Chinese resident identity number format
        /// </summary>
        public EmptyValidator ResidentIdNumber { get; set; } = null;

        /// <summary>
        /// Indicates that the content should be validated as such that the customer has accepted the field as if they were terms and conditions of a service
        /// </summary>
        public EmptyValidator TermsAndConditions { get; set; } = null;
    }
}
