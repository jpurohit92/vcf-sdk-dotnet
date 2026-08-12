# Vcenter.ViJson.OpenApi.Model.SeSparseVirtualDiskSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CapacityKb** | **long** | Specify the capacity of the virtual disk in Kb.  | 
**Profile** | [**List&lt;VirtualMachineProfileSpec&gt;**](VirtualMachineProfileSpec.md) | Virtual Disk Profile requirement.  Profiles are solution specifics. Profile Based Storage Management is a vSphere server extension. The API users who want to provision VMs using Storage Profiles, need to interact with it. This is an optional parameter and if user doesn&#39;t specify profile, the default behavior will apply.  | [optional] 
**Crypto** | [**CryptoSpec**](CryptoSpec.md) | Encryption options for the new virtual disk.  | [optional] 
**SectorFormat** | **string** | Optional sector format.  If not specified, an appropriate default format will be chosen by the storage system. If available, native\\_512 is preferred. For the list of supported values, see *DatastoreSectorFormat_enum*.  ***Since:*** vSphere API Release 9.0.0.0  | [optional] 
**GrainSizeKb** | **int** | The grain size in kB for Flex-SE disk types.  Default value will be used if unset.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

