using CsvHelper.Configuration;
using ReadBlobAndStoreInSQL.Models;

namespace ReadBlobAndStoreInSQL.Mapper
{
    public class ContractMapper : ClassMap<ContractDetails>
    {
        public ContractMapper()
        {
            Map(m => m.ContractId).Name("contract_id");
            Map(m => m.ContractName).Name("name");
            Map(m => m.CounterParty).Name("counterparty");
            Map(m => m.Price).Name("price");
        }
    }
}
