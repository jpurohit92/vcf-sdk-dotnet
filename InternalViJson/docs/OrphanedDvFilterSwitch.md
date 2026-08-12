# Vcenter.ViJson.OpenApi.Model.OrphanedDvFilterSwitch
Deprecated dvFilters are no longer supported by EAM.  A dvFilter switch exists on a host but no agents on the host depend on dvFilter.  This typically happens if a host is disconnected when an agency configuration changed.  This is an active remediable issue. To remediate, vSphere ESX Agent Manager removes the dvFilterSwitch.  This structure may be used only with operations rendered under `/eam`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | The host to which the issue is related.  Refers instance of *HostSystem*.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

