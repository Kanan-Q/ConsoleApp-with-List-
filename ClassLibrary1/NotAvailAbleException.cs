using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    internal class NotAvailAbleException:Exception
    {
        public NotAvailAbleException(string message):base(message) { }
    }
}
