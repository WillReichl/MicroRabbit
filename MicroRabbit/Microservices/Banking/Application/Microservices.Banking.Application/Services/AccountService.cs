using MicroRabbit.Banking.Domain.Commands;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using MicroRabbit.Domain.Core.Bus;
using Microservices.Banking.Application.Dtos;
using Microservices.Banking.Application.Interfaces;
using System.Collections.Generic;

namespace Microservices.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IEventBus _eventBus;

        public AccountService(IAccountRepository accountRepository, IEventBus eventBus)
        {
            this._accountRepository = accountRepository;
            this._eventBus = eventBus;
        }

        public IEnumerable<Account> GetAccounts()
        {
            return _accountRepository.GetAccounts();
        }

        public void TransferFunds(AccountTransferDto accountTransfer)
        {
            var createTransferCommand =
                new CreateTransferCommand(accountTransfer.FromAccountId, accountTransfer.ToAccountId, accountTransfer.TransferAmount);

            _eventBus.SendCommand(createTransferCommand);
        }
    }
}