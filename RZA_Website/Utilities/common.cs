using System.Text;

namespace RZA_Website.Utilities
{
    public class UserSession
    {
        public int UserID { get; set; }
    }
    public static class PasswordUtils
    {
        
        private static readonly char[] specialCharacters = new char[]
        {
            '!','£','$','%','^','&','*','(',')','-','=','_','+','[',']','{','}',';',':','@','#','~','<','>'
        };
        private static readonly char[] digits = new char[]
        {
            '1','2','3','4','5','6','7','8','9','0'
        };

        public static async Task<bool> ValidPassword(string password)
        {
            bool valid = true;
            if (password.Length < 8)
            {
                return false;
            }
            else if (!digits.Any(d => password.Contains(d)))
            {
                return false;
            }
            else if (!specialCharacters.Any(sc => password.Contains(sc)))
            {
                return false;
            }
            else if (password.ToUpper() == password)
            {
                return false;
            }
            return valid;
        }
       
    }
}
