namespace Ex9.Models
{
    public class UserDto
    {
        /// <summary>
        /// Source: FirstName, MiddleName, LastName
        /// Format example: Anna Maria Wesołowska
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Source: Birthday
        /// Format example: "Monday, 20 May 2020 13:54"
        /// </summary>
        public string Birthdate { get; set; }

        /// <summary>
        /// Source: Email, true if email has @ and .
        /// </summary>
        public bool IsEmailInCorrectFormat { get; set; }

        /// <summary>
        /// Source: Email, should be changed to uppercase, should contain "?" if email is null
        /// Format example: "?" or "EXAMPLEEMAIL@MAIL.COM"
        /// </summary>
        public string NormalizedEmail { get; set; }

        /// <summary>
        /// Source: PhoneNumber, PhoneCountryCode
        /// Format example: "+48112853928"
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Source: Identification.Value
        /// </summary>
        public int IdNumber { get; set; }

        /// <summary>
        /// Has to be ignored in mapping
        /// </summary>
        public string Details { get; set; }
    }
}
