using System;
using System.Collections.Generic;
using System.Text;

namespace Microservices.Banking.Application.Dtos
{
    public class AccountTransferDto
    {
        public int FromAccountId { get; set; }
        public int ToAccountId { get; set; }
        public decimal TransferAmount { get; set; }
    }
}
