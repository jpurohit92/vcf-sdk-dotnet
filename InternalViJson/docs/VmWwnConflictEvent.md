# Vcenter.ViJson.OpenApi.Model.VmWwnConflictEvent

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Template** | **bool** | Indicates whether or not the virtual machine is marked as a template.  | 
**ConflictedVms** | [**List&lt;VmEventArgument&gt;**](VmEventArgument.md) | The virtual machine whose WWN conflicts with the current virtual machine&#39;s WWN.  | [optional] 
**ConflictedHosts** | [**List&lt;HostEventArgument&gt;**](HostEventArgument.md) | The host whose physical WWN conflicts with the current virtual machine&#39;s WWN.  | [optional] 
**Wwn** | **long** | The WWN in conflict.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

