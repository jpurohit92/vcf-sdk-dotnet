# Vcenter.ViJson.OpenApi.Model.KmipClusterInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClusterId** | [**KeyProviderId**](KeyProviderId.md) | Globally unique ID for the servers providing the same keys.  All KMIP servers with the same clusterId are in a cluster and all must provide the same keys for redundancy.  | 
**Servers** | [**List&lt;KmipServerInfo&gt;**](KmipServerInfo.md) | Servers in this cluster.  | [optional] 
**UseAsDefault** | **bool** | Use this cluster as default for system wide, when the optional CryptoKeyId.providerId is not set.  | 
**ManagementType** | **string** | Key provider management type.  See *KmipClusterInfoKmsManagementType_enum* for valid values.  | [optional] 
**UseAsEntityDefault** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | Use this cluster as default for the managed entities, when the optional CryptoKeyId.providerId is not set.  See *CryptoManagerKmip.SetDefaultKmsCluster* for supported managed entity type.  Refers instances of *ManagedEntity*.  | [optional] 
**HasBackup** | **bool** | ***Since:*** vSphere API Release 7.0.2.0  | [optional] 
**TpmRequired** | **bool** | ***Since:*** vSphere API Release 7.0.2.0  | [optional] 
**KeyId** | **string** | ***Since:*** vSphere API Release 7.0.2.0  | [optional] 
**DefaultKeyType** | **string** | Key type which the key provider generates by default.  See *KmipClusterInfoKeyType_enum* for supported values.  ***Since:*** vSphere API Release 9.0.0.0  | [optional] 
**KeyInfo** | [**KmipClusterInfoKeyInfo**](KmipClusterInfoKeyInfo.md) | Key information.  ***Since:*** vSphere API Release 9.0.0.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

