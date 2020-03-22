using MicroRabbit.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Domain.Commands
{
    public abstract class TransferCommand : Command
    {
        public int FromAccountId { get; protected set; }
        public int ToAccountId { get; protected set; }
        public decimal TransferAmount { get; set; }
    }
}
