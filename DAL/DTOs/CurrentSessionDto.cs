using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTOs
{
    public class CurrentSessionDto
    {
        public int Id { get; set; }
        public string ApplicationName { get; set; }
        public string UserId { get; set; }
        public DateTime LogInTime { get; set; }
        public DateTime LastOperationTime { get; set; }

    }
}
