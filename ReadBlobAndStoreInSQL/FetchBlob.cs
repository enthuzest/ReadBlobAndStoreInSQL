using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using ReadBlobAndStoreInSQL.Mapper;
using ReadBlobAndStoreInSQL.Models;
using ReadBlobAndStoreInSQL.Services;

namespace ReadBlobAndStoreInSQL
{
    public class FetchBlob
    {
        private readonly IContractService _service;

        public FetchBlob(IContractService service)
        {
            _service = service;
        }

        [FunctionName("FetchContractFromCSV")]
        public void Run([BlobTrigger("%blobName%", Connection = "blobConnection")] Stream myBlob, string name, ILogger log)
        {
            log.LogInformation($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes");
            try
            {
                using StreamReader reader = new(myBlob);
                using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
                csv.Context.RegisterClassMap<ContractMapper>();
                IEnumerable<ContractDetails> records = csv.GetRecords<ContractDetails>();             

                var result = _service.SaveContracts(records);

               log.LogInformation("Contract Details Saved in DB");
            }
            catch (Exception ex)
            {
                log.LogError($"Error while saving contract details {ex.Message}");
            }
        }
    }
}
