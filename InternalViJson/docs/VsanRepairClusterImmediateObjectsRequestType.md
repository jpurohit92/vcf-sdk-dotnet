# Vcenter.ViJson.OpenApi.Model.VsanRepairClusterImmediateObjectsRequestType
The parameters of *VsanClusterHealthSystem.VsanRepairClusterImmediateObjects*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Hosts** | **List&lt;string&gt;** | The vSAN hosts  | 
**EsxRootPassword** | **string** | The root password for the host. The password should be the same for all of hosts in the vSAN cluster  | 
**Uuids** | **List&lt;string&gt;** | The vSAN objects UUID to be repaired. Unset to repair all of reduced objects in the vSAN cluster  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

