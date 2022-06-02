using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexExpection
{
    public class RegexCustomExpection : Exception
    {
        Exceptiontype type;
        public enum Exceptiontype
        {
            FIRSTNAME_INVALID, LASTNAME_INVALID, EMAILID_INVALID, MOBILE_INVALID, PASSWORD_INVALID
        }
        public RegexCustomExpection(Exceptiontype type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
