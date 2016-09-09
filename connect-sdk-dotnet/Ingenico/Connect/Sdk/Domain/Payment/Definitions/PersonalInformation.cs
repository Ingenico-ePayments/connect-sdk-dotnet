/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_PersonalInformation">PersonalInformation</a>
    /// </summary>
    public class PersonalInformation
    {
        public string DateOfBirth { get; set; } = null;

        public string Gender { get; set; } = null;

        public PersonalName Name { get; set; } = null;
    }
}
