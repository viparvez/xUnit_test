namespace Calculations
{
    public class Names
    {
        public string NickName { get; set; }

        public string FullName(string firstName, string lastName)
        {
            return $"{firstName} {lastName}";
        }

        public string FullNameWithMrOrMrs(string firstName, string lastName, bool isMale)
        {
            var salutation = isMale ? "Mr." : "Mrs.";
            return $"{salutation} {firstName} {lastName}";
        }
    }
}
