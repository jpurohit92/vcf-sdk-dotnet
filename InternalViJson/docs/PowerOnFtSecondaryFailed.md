# Vcenter.ViJson.OpenApi.Model.PowerOnFtSecondaryFailed

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | The primary virtual machine corresponding to the secondary that is to be powered on  Refers instance of *VirtualMachine*.  | 
**VmName** | **string** | The name of the primary virtual machine corresponding to the secondary that is to be powered on.  | 
**HostSelectionBy** | **FtIssuesOnHostHostSelectionTypeEnum** | The host selection type  | 
**HostErrors** | [**List&lt;MethodFault&gt;**](MethodFault.md) | Information on why the system can not power on a Fault Tolerance secondary virtual machine on specific hosts.  Everything in the array should be FtIssuesOnHost.  | [optional] 
**RootCause** | [**MethodFault**](MethodFault.md) | The reason why powering on secondary failed.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

