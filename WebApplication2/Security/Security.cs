using System.Text.RegularExpressions;

namespace WebApplication2.Security
{
    public class Security
    {
        public static bool IsValidInput_SQLInjection(string input)
        {
            // Only accept alphabets in the range of 10 caracters 
            string regEx = "^[a-zA-Z]{1,10}$";
            if(!String.IsNullOrEmpty(input) && Regex.IsMatch(input,regEx)) {
                return true;
            }
            return false;
        }
    }
}
