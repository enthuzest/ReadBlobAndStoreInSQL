using ReadBlobAndStoreInSQL.Models.Database;
using System.Collections.Generic;

namespace ReadBlobAndStoreInSQL.Repository
{
    public interface IContractRepo
    {
        public bool SaveContracts(IEnumerable<TblContract> contractDetails);
    }
}
