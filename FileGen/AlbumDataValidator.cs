using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FileGen
{
    public class AlbumDataValidator
    {

        public bool isValid = true;

        public AlbumDataValidator() {}

        public AlbumDataValidator isValidText(string text) {
            if (text.Length == 0)
                isValid = false;
            else
                isValid = true;
         
            return this;
        }

        public bool IsValidPassowrd(string password) 
        {
            const string passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";

            if (!Regex.IsMatch(password, passwordPattern))
            {
                ShowWarningMessage("password contains at least one lowercase letter, one uppercase letter, one digit, and one special character. It also specifies a minimum length of 6 and maximum lenght of 20 characters.");
                return false;
            }

            if (password.Length >= 6 && password.Length <= 20)
            {
                ShowWarningMessage("password contains at least one lowercase letter, one uppercase letter, one digit, and one special character. It also specifies a minimum length of 6 and maximum lenght of 20 characters.");
                return false;
            }
           
            return true;
        }


        private void ShowWarningMessage(string reason) 
        {
            MessageBox.Show(reason , "Invalid or empty text!" , MessageBoxButtons.OK , MessageBoxIcon.Warning);
        }

    }
}
