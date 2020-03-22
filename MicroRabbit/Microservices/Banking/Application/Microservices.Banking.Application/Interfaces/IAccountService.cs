using MicroRabbit.Banking.Domain.Models;
using Microservices.Banking.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microservices.Banking.Application.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAccounts();
        void TransferFunds(AccountTransferDto accountTransfer);
    }
}
