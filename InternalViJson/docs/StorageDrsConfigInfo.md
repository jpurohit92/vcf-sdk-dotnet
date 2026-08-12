# Vcenter.ViJson.OpenApi.Model.StorageDrsConfigInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PodConfig** | [**StorageDrsPodConfigInfo**](StorageDrsPodConfigInfo.md) | Pod-wide configuration of the storage DRS service.  | 
**VmConfig** | [**List&lt;StorageDrsVmConfigInfo&gt;**](StorageDrsVmConfigInfo.md) | List of virtual machine configurations for the storage DRS service.  Each entry applies to all the virtual disks of the virtual machine on this pod.  If a virtual machine is not specified in this array, the service uses the default settings for that virtual machine.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

