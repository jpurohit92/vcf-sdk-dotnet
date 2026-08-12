# Vcenter.ViJson.OpenApi.Model.PromoteDisksRequestType
The parameters of *VirtualMachine.PromoteDisks_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Unlink** | **bool** | If true, disks on powered-off VMs are unlinked before consolidation. This has no effect on powered-on VMs, as child disks are unlinked by default.  | 
**Disks** | [**List&lt;VirtualDisk&gt;**](VirtualDisk.md) | The set of disks that are to be promoted. If this value is unset or the array is empty, all disks which have delta disk backings are promoted.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

