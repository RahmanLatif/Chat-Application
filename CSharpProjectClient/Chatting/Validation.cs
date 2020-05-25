using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatting
{
    static class Validation
    {
        public static bool Valid_UserName(string name)
        {
            if (name.Length < 5)
                return false;
            return true;
        }
        public static bool Valid_password(string password)
        {
            int c1 = 0, c2 = 0, c3 = 0;
            for (int i = 0; i < password.Length; i++)
                if (char.IsDigit(password[i]))
                    ++c1;
                else if (char.IsUpper(password[i]))
                    ++c2;
                else if (char.IsLower(password[i]))
                    ++c3;
            if (password.Length >= 8 && c1 > 0 && c2 > 0 && c3 > 0)
                return true;
            return false;
        }
        public static bool Valid_Date(DateTime dt)
        {
            return (DateTime.Now.Subtract(dt).Days / 364 >= 14);
        }
    }
}
