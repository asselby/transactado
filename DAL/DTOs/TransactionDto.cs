using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTOs
{
    public enum TransactionType
    {
        ClientToClientTransaction,
        ClientToBankTransaction
    }
    public class TransactionDto
    {
        public Guid Id { get; set; }
        public string SenderId { get; set; }
        public string ReceiverId { get; set; }
        public TransactionType TransactionType { get; set; }
        public DateTime TransactionTime { get; set; }
        public decimal TransactionAmount { get; set; }
    }
}
