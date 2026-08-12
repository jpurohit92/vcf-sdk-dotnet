# Vcenter.ViJson.OpenApi.Model.VirtualMachineFilePath

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VcUuid** | **string** | The vCenter UUID - this is informational only, and may not always be set.  | [optional] 
**DsUrl** | **string** | Datastore URL, which is globally unique (name is not).  | 
**VmxPath** | **string** | Full path name from the URL onwards.  When the vmxPath is returned after failover, the VMX file should be fixed up to contain correct target filenames for all replicated disks. For non-replicated disks, the target filenames can contain any arbitrary path. For better security, it is recommended to set these disks pointed to a random string (e.g. UUID).  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

