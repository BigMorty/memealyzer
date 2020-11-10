using DotNetEnv;
using System;

namespace Lib
{
    public static class Config
    {
        public static readonly string BaseName = Env.GetString("BASENAME");
        public static readonly Uri CosmosEndpoint = new Uri(String.Format(Env.GetString("AZURE_COSMOS_ENDPOINT", "https://{0}cosmosaccount.documents.azure.com:443/"), BaseName));
        public static readonly Uri FormRecognizerEndpoint = new Uri(String.Format(Env.GetString("AZURE_FORM_RECOGNIZER_ENDPOINT", "https://{0}formrecognizer.cognitiveservices.azure.com/"), BaseName));
        public static readonly Uri KeyVaultEndpoint = new Uri(String.Format(Env.GetString("AZURE_KEYVAULT_ENDPOINT", "https://{0}kv.vault.azure.net/"), BaseName));
        public static readonly string StorageAccountName = String.Format(Env.GetString("AZURE_STORAGE_ACCOUNT_NAME", "{0}storage"), BaseName);
        public static readonly Uri StorageBlobEndpoint = new Uri(String.Format(Env.GetString("AZURE_STORAGE_BLOB_ENDPOINT", "https://{0}storage.blob.core.windows.net/"), BaseName));
        public static readonly Uri StorageQueueEndpoint = new Uri(String.Format(Env.GetString("AZURE_STORAGE_QUEUE_ENDPOINT", "https://{0}storage.queue.core.windows.net/"), BaseName));
        public static readonly Uri StorageTableEndpoint = new Uri(String.Format(Env.GetString("AZURE_STORAGE_TABLE_ENDPOINT", "https://{0}storage.table.core.windows.net/"), BaseName));
        public static readonly Uri TextAnalyticsEndpoint = new Uri(String.Format(Env.GetString("AZURE_TEXT_ANALYTICS_ENDPOINT", "https://{0}textanalytics.cognitiveservices.azure.com/"), BaseName));
        public static readonly Uri AppConfigEndpoint = new Uri(String.Format(Env.GetString("AZURE_APP_CONFIG_ENDPOINT", "https://{0}appconfig.azconfig.io"), BaseName));
        public static readonly string ContainerRegistryServer = String.Format(Env.GetString("AZURE_CONTAINER_REGISTRY_SERVER", "{0}acr.azurecr.io"), BaseName);
        public static readonly string StorageBlobContainerName = Env.GetString("AZURE_STORAGE_BLOB_CONTAINER_NAME", "blobs");
        public static readonly string StorageQueueName = Env.GetString("AZURE_STORAGE_QUEUE_NAME", "messages");
        public static readonly int StorageQueueMessageCount = Env.GetInt("AZURE_STORAGE_QUEUE_MSG_COUNT", 10);
        public static readonly int StorageQueueReceiveSleep = Env.GetInt("AZURE_STORAGE_QUEUE_RECEIVE_SLEEP", 1);
        public static readonly string StorageTableName = Env.GetString("AZURE_STORAGE_TABLE_NAME", "images");
        public static readonly string CosmosDB = Env.GetString("AZURE_COSMOS_DB", "memealyzer");
        public static readonly string CosmosCollection = Env.GetString("AZURE_COSMOS_COLLECTION", "images");
        public static readonly string CosmosKeySecretName = Env.GetString("AZURE_COSMOS_KEY_SECRET_NAME", "CosmosKey");
        public static readonly string StorageType = Env.GetString("AZURE_STORAGE_TYPE", "COSMOS_SQL");
        public static readonly string StorageKeySecretName = Env.GetString("AZURE_STORAGE_KEY_SECRET_NAME", "StorageKey");
        public static readonly string StorageClientSyncQueueName = Env.GetString("AZURE_STORAGE_CLIENT_SYNC_QUEUE_NAME", "sync");
        public static readonly string SignalRConnectionStringSecretName = Env.GetString("AZURE_SIGNALR_CONNECTION_STRING_SECRET_NAME", "SignalRConnectionString");
        public static readonly string StorageConnectionStringSecretName = Env.GetString("AZURE_STORAGE_CONNECTION_STRING_SECRET_NAME", "StorageConnectionString");
        public static readonly string MemeEndpoint = Env.GetString("MEME_ENDPOINT", "https://meme-api.herokuapp.com/gimme/wholesomememes");
        public static readonly string AzuriteAccountKey = Env.GetString("AZURITE_ACCOUNT_KEY");
        public static readonly string CosmostKey = Env.GetString("AZURE_COSMOS_KEY");
    }
}