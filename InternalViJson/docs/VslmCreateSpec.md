# Vcenter.ViJson.OpenApi.Model.VslmCreateSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ID**](ID.md) | The ID of the virtual storage object.  If specified, the id will be used as an identifier for the created virtual storage object. For each new request, the ID should be a unique ID complying to RFC4122V4 (generated randomly). For retry requests with the same ID, all the other input parameters in the spec are expected to remain same. If not specified, a system generated ID will be used as identifier for the virtual storage object.  ***Since:*** vSphere API Release 9.1.0.0  | [optional] 
**Name** | **string** | Descriptive name of this virtual storage object.  | 
**KeepAfterDeleteVm** | **bool** | Choice of the deletion behavior of this virtual storage object.  If not set, the default value is true.  | [optional] 
**BackingSpec** | [**VslmCreateSpecBackingSpec**](VslmCreateSpecBackingSpec.md) | Specification of the backings of the virtual storage object.  | 
**CapacityInMB** | **long** | Size in MB of the virtual storage object.  | 
**Profile** | [**List&lt;VirtualMachineProfileSpec&gt;**](VirtualMachineProfileSpec.md) | Virtual storage object Profile requirement.  If unset, the default behavior will apply.  | [optional] 
**Crypto** | [**CryptoSpec**](CryptoSpec.md) | Crypto operation of the disk.  If unset and if *VslmCreateSpec.profile* contains an encryption iofilter, then crypto will be of type CryptoSpecEncrypt, and filled with keyId that is automatically generated and keyProviderId that is the default kms cluster.  | [optional] 
**Metadata** | [**List&lt;KeyValue&gt;**](KeyValue.md) | The metadata KV pairs that are supposed to be created on the newly created virtual storage object.  The create task is atomic by design. That being said, failing to add the specified metadata pairs leads to the failure of the create task. If unset, no metadata will be added. An empty string value is indicative of a vcenter tag.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

