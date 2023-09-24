using Microsoft.Extensions.Logging;
using ReadBlobAndStoreInSQL.Models;
using ReadBlobAndStoreInSQL.Models.Database;
using ReadBlobAndStoreInSQL.Repository;
using System.Collections.Generic;
using System.Linq;

namespace ReadBlobAndStoreInSQL.Services
{
    public class ContractService : IContractService
    {
        private readonly IContractRepo _contractRepo;
        private readonly ILogger<ContractService> _log;

        public ContractService(IContractRepo contractRepo, ILogger<ContractService> log)
        {
            _contractRepo = contractRepo;
            _log = log;
        }

        public bool SaveContracts(IEnumerable<ContractDetails> contractDetails)
        {
            var mappedContractDetails = contractDetails.Select(a => new TblContract()
            {
                ContractId = a.ContractId,
                ContractName = a.ContractName,
                Counterparty = a.CounterParty,
                Price = a.Price
            }).ToList();

            _log.LogInformation($"Contracts are mapped successfully");

            return _contractRepo.SaveContracts(mappedContractDetails);
        }
    }
}
