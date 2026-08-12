# Vcenter.ViJson.OpenApi.Model.VslmCloneSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BackingSpec** | [**VslmCreateSpecBackingSpec**](VslmCreateSpecBackingSpec.md) | Specification of the backings of the target virtual storage object.  | 
**Profile** | [**List&lt;VirtualMachineProfileSpec&gt;**](VirtualMachineProfileSpec.md) | Virtual storage object Profile requirement.  If unset, the default behavior will apply.  | [optional] 
**Consolidate** | **bool** | Flag indicates any delta disk backings will be consolidated during clone/migration.  Cloning of linked clone disks always require consolidation.  | [optional] 
**DisksCrypto** | [**DiskCryptoSpec**](DiskCryptoSpec.md) | Disk chain crypto information.  If unset and if *VslmMigrateSpec.profile* contains an encryption iofilter and if source VStorageObject is unencrypted, then disksCrypto will be of type CryptoSpecEncrypt, and filled with keyId that is automatically generated and keyProviderId that is the default kms cluster. During the migration, the object will be encrypted. If unset and if *VslmMigrateSpec.profile* is a default policy and if source VStorageObject is unenrypted, then disksCrypto is treated as CryptoSpecNoOp. During migration, no cryptographic change. If unset and if *VslmMigrateSpec.profile* contains an encryption iofilter and if source VStorageObject is encrypted, then disksCrypto is treated as CryptoSpecNoOp. During migration, no cryptographic change. If unset and if *VslmMigrateSpec.profile* is a default policy and if source VStorageObject is encrypted, then disksCrypto is treated as CryptoSpecDecrypt, during migration, the object will be decrypted. To recrypt the disk during migration, disksCrypto has to be present.  | [optional] 
**Service** | [**ServiceLocator**](ServiceLocator.md) | The service endpoint of vCenter where the FCD should be located.  If not specified the current vCenter service is used.  ***Since:*** vSphere API Release 8.0.3.0  | [optional] 
**Name** | **string** | Descriptive name of the cloned virtual storage object.  | 
**KeepAfterDeleteVm** | **bool** | Choice of the deletion behavior of this virtual storage object.  If not set, the default value is false.  | [optional] 
**Metadata** | [**List&lt;KeyValue&gt;**](KeyValue.md) | The metadata KV pairs that are supposed to be updated on the destination virtual storage object.  The clone task is atomic by design. That being said, failing to update the specified metadata pairs leads to the failure of the clone task. If unset, no metadata will be updated. An empty string value is indicative of a vcenter tag.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

