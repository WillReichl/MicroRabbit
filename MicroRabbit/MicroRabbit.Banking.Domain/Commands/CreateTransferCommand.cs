using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Domain.Commands
{
    public class CreateTransferCommand : TransferCommand
    {
        public CreateTransferCommand(int fromAccountId, int toAccountId, decimal transferAmount)
        {
            this.FromAccountId = fromAccountId;
            this.ToAccountId = toAccountId;
            this.TransferAmount = transferAmount;
        }
    }
}
