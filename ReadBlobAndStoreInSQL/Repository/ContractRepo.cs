using Microsoft.Extensions.Logging;
using ReadBlobAndStoreInSQL.Models.Database;
using System.Collections.Generic;
using System.Linq;

namespace ReadBlobAndStoreInSQL.Repository
{
    public class ContractRepo : IContractRepo
    {
        private readonly ContractContext _dbcontext;
        private readonly ILogger<ContractRepo> _log;

        public ContractRepo(ContractContext dbcontext, ILogger<ContractRepo> log)
        {
            _dbcontext = dbcontext;
            _log = log;
        }
        public bool SaveContracts(IEnumerable<TblContract> contractDetails)
        {
            _log.LogInformation($"Number of contracts found :: {contractDetails.Count()}");
            _dbcontext.TblContracts.AddRange(contractDetails);
            return (_dbcontext.SaveChanges() > 0);
        }
    }
}
