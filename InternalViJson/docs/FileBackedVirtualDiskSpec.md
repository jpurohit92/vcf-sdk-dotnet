# Vcenter.ViJson.OpenApi.Model.FileBackedVirtualDiskSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DiskType** | **string** | The type of the new virtual disk.  See also *VirtualDiskType_enum*.  | 
**AdapterType** | **string** | The type of the virtual disk adapter for the new virtual disk.  See also *VirtualDiskAdapterType_enum*.  | 
**CapacityKb** | **long** | Specify the capacity of the virtual disk in Kb.  | 
**Profile** | [**List&lt;VirtualMachineProfileSpec&gt;**](VirtualMachineProfileSpec.md) | Virtual Disk Profile requirement.  Profiles are solution specifics. Profile Based Storage Management is a vSphere server extension. The API users who want to provision VMs using Storage Profiles, need to interact with it. This is an optional parameter and if user doesn&#39;t specify profile, the default behavior will apply.  | [optional] 
**Crypto** | [**CryptoSpec**](CryptoSpec.md) | Encryption options for the new virtual disk.  | [optional] 
**SectorFormat** | **string** | Optional sector format.  If not specified, an appropriate default format will be chosen by the storage system. If available, native\\_512 is preferred. For the list of supported values, see *DatastoreSectorFormat_enum*.  ***Since:*** vSphere API Release 9.0.0.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

