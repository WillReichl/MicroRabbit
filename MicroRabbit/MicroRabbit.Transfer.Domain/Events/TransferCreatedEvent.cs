using MicroRabbit.Domain.Core.Events;

namespace MicroRabbit.Transfer.Domain.Events
{
    public class TransferCreatedEvent : Event
    {
        public TransferCreatedEvent(int fromAccountId, int toAccountId, decimal transferAmount)
        {
            FromAccountId = fromAccountId;
            ToAccountId = toAccountId;
            TransferAmount = transferAmount;
        }

        public int FromAccountId { get; private set; }
        public int ToAccountId { get; private set; }
        public decimal TransferAmount { get; private set; }
    }
}