/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Product.Definitions
{
    public class BoletoBancarioRequirednessValidator
    {
        /// <summary>
        /// When performing a payment with Boleto Bancario, some values are only required when the fiscalnumber has a specific length. The length the fiscalnumber has to have to make the field required is defined here. For example the CompanyName is required when the fiscalnumber is a CNPJ. The firstname and surname are required when the fiscalnumber is a CPF.
        /// </summary>
        public int? FiscalNumberLength { get; set; } = null;
    }
}
