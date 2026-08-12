# Vcenter.ViJson.OpenApi.Model.CreateDiskFromSnapshotRequestType
The parameters of *VcenterVStorageObjectManager.CreateDiskFromSnapshot_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ID**](ID.md) | The ID of the virtual storage object.  | 
**Datastore** | [**ManagedObjectReference**](ManagedObjectReference.md) | The datastore where the source virtual storage object is located.  Refers instance of *Datastore*.  | 
**SnapshotId** | [**ID**](ID.md) | The ID of the snapshot of the virtual storage object.  | 
**Name** | **string** | A user friendly name to be associated with the new disk.  | 
**Profile** | [**List&lt;VirtualMachineProfileSpec&gt;**](VirtualMachineProfileSpec.md) | SPBM Profile requirement on the new virtual storage object. If not specified datastore default policy would be assigned.  | [optional] 
**Crypto** | [**CryptoSpec**](CryptoSpec.md) | Crypto information of the new disk. If unset and if profile contains an encryption iofilter and if snapshto is unencrypted, then crypto will be of type CryptoSpecEncrypt, and filled with keyId that is automatically generated and keyProviderId that is the default kms cluster. If unset and if profile is a default policy and if snapshot is unenrypted, then crypto is treated as CryptoSpecNoOp. If unset and if profile contains an encryption iofilter and if snapshot is encrypted, then crypto is treated as CryptoSpecNoOp. If unset and if profile is a default policy and if snapshot is encrypted, then crypto is treated as CryptoSpecDecrypt. To recrypt the disk during creating disk, crypto has to be present.  | [optional] 
**Path** | **string** | Relative location where disk has to be created, used in &#x60;targetDatastore&#x60; and &#x60;datastore&#x60; parameters. If not specified disk gets created at default *VStorageObject* location of &#x60;targetDatastore&#x60; or &#x60;datastore&#x60;.  | [optional] 
**IsLinkedClone** | **bool** | Indicates whether a linkedClone Disk needs to be created from the snapshot.  ***Since:*** vSphere API Release 9.1.0.0  | [optional] 
**TargetId** | [**ID**](ID.md) | The ID of the target virtual storage object. For each new request, the ID should be a unique ID complying to RFC4122V4 (generated randomly). For retry requests with the same ID, all the other input parameters are expected to remain same. If not specified, a system generated ID will be assigned to the newly created virtual storage object.  ***Since:*** vSphere API Release 9.1.0.0  | [optional] 
**TargetDatastore** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target datastore where the new disk needs to be created. if not specified, the new disk will be created where the source virtual storage object is located.  ***Since:*** vSphere API Release 9.1.0.0  Refers instance of *Datastore*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

