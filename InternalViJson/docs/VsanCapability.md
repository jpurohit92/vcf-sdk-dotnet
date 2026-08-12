# Vcenter.ViJson.OpenApi.Model.VsanCapability

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Target** | [**ManagedObjectReference**](ManagedObjectReference.md) | The managed object that owns the capabilities.  It is an optional field that could be HostSystem, ClusterComputeResource or nothing. If it is empty, this means that the attached capabilities rely to the vCenter itself.  | [optional] 
**Capabilities** | **List&lt;string&gt;** | A list of capabilities that the target object supports.  All valid capabilities are listed in below enumerations: *VsanCapabilityType_enum*, *VsanCapabilityType90_enum* *VsanCapabilityType91_enum*  | [optional] 
**Statuses** | **List&lt;string&gt;** | A list of statuses that indicate target object&#39;s status when retrieving capabilities.  For example, if capabilities retrieved from a host is empty, this field can be used to clarify the specific reasons.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

