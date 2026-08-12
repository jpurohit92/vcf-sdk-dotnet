# Vcenter.ViJson.OpenApi.Model.CryptoManagerKmipCryptoKeyStatus

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**KeyId** | [**CryptoKeyId**](CryptoKeyId.md) | Crypto key Id  | 
**KeyAvailable** | **bool** | If the key is available for crypto operation  | [optional] 
**Reason** | **string** | The reason for key not available, valid when keyAvailable is false.  *CryptoManagerKmipCryptoKeyStatusKeyUnavailableReason_enum* lists the set of supported values.  | [optional] 
**KeyInfo** | [**CryptoManagerKmipCryptoKeyStatusKeyInfo**](CryptoManagerKmipCryptoKeyStatusKeyInfo.md) | The key info of the wrapped key.  If key is not a wrapped, then it will unset.  ***Since:*** vSphere API Release 9.0.0.0  | [optional] 
**EncryptedVMs** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | The list of VMs which use that key  Refers instances of *VirtualMachine*.  | [optional] 
**AffectedHosts** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | The lists of hosts which use that key as host key  Refers instances of *HostSystem*.  | [optional] 
**ReferencedByTags** | **List&lt;string&gt;** | The identifier list for the 3rd party who are using the key  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

