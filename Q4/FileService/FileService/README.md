# File Service Storage with Azure Blob

- To use the Azure Local Storage Emulator I have follow this [page tutorial](https://learn.microsoft.com/en-us/azure/storage/common/storage-use-emulator)

- Follow these steps to create an Azure Local Storage:

1) Download the [Storage Emulator](https://go.microsoft.com/fwlink/?linkid=717179&clcid=0x409)

2) Setup the storage emulator using a local SQLDB "AzureStorageEmulator.exe init /server (localdb)\MSSQLLocalDb"

3) Then start the storage emulator using "AzureStorageEmulator.exe start"

> **_NOTE:_**  Is recommended use MSQLSMS to check the changes in the Azure Blob Storage and the database with the file metadata.

- To test this solution, just open it on Visual Studio 2022, run it and upload a file through the Swagger UI.

# Use in a real Azure Blob Storage

1) Create an account on [Microsoft Azure Portal](https://azure.microsoft.com/en-us/)

2) Go to Create New Resource > Select Storage in Categories > Storage Account > Create.

3) Once you have created your account. Access it, go to Access keys and coppy the connection string.

4) And replace the value of "AzureBlobStorage" with the key value in the appsettings.

5) If you have a specific container to be used, copy the value to the setting "ContainerName".