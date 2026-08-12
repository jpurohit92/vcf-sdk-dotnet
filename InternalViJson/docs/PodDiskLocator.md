# Vcenter.ViJson.OpenApi.Model.PodDiskLocator

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DiskId** | **int** | The disk ID.  | 
**DiskMoveType** | **string** | The disk move type.  | [optional] 
**DiskBackingInfo** | [**VirtualDeviceBackingInfo**](VirtualDeviceBackingInfo.md) | The disk backing info.  | [optional] 
**Profile** | [**List&lt;VirtualMachineProfileSpec&gt;**](VirtualMachineProfileSpec.md) | Virtual Disk Profile requirement.  Profiles are solution specific. Profile Based Storage Management is a vSphere server extension. The API users who want to provision VMs using Storage Profiles, need to interact with it. This is an optional parameter and if user doesn&#39;t specify profile, the default behavior will apply.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

