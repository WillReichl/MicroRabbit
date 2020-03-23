﻿using MicroRabbit.MVC.Models.DTO;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace MicroRabbit.MVC.Services
{
    public class TransferService : ITransferService
    {
        private readonly HttpClient _apiClient;

        public TransferService(HttpClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task Transfer(TransferDto transferDto)
        {
            var bankingUri = "http://localhost:5000/api/banking";
            var transferContent = new StringContent(
                JsonConvert.SerializeObject(transferDto),
                System.Text.Encoding.UTF8,
                "application/json");

            var response = await _apiClient.PostAsync(bankingUri, transferContent);
            response.EnsureSuccessStatusCode();
        }
    }
}