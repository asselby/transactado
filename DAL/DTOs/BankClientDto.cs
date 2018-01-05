using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTOs
{
    public class BankClientDto : ApplicationClient
    {
        public string Name { get; set; }
        public string AccountNumber { get; set; }
    }
}
