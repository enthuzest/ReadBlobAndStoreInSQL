using ReadBlobAndStoreInSQL.Models;
using System.Collections.Generic;

namespace ReadBlobAndStoreInSQL.Services
{
    public interface IContractService
    {
        bool SaveContracts(IEnumerable<ContractDetails> contractDetails);
    }
}
