using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using System.Collections.Generic;

namespace MicroRabbit.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private readonly TransferDbContext _transferDbContext;

        public TransferRepository(TransferDbContext transferDbContext)
        {
            _transferDbContext = transferDbContext;
        }

        IEnumerable<TransferLog> ITransferRepository.GetTransferLogs()
        {
            var transferLogs = _transferDbContext.TransferLogs;
            return transferLogs;
        }
    }
}