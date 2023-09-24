# ReadBlobAndStoreInSQL
Blob trigger to save csv into SQL table

## Description
Once the Blob is uploaded into the storage account, function app will get triggered and save the csv data into SQL table.

## Getting Started
Add these settings in local.settings.json
```
{
  "IsEncrypted": false,
  "Values": {
    "AzureWebJobsStorage": "UseDevelopmentStorage=true",
    "FUNCTIONS_WORKER_RUNTIME": "dotnet",
    "blobName": "content/{name}",
    "blobConnection__serviceUri ": "https://{storage-account-name}.blob.core.windows.net",
    "AzureWebJobsblobConnection__serviceUri": "https://{storage-account-name}.blob.core.windows.net",
    "SqlConnectionString": "Server={DB-Server-Name};Database=falcon;Trusted_Connection=True;"
  }
}
```

## Authors
Faraz Ahmad Siddiqui 
[@FarazAhmad](https://www.linkedin.com/in/faraz-ahmad-340001113/)
