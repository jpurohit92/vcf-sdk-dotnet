# Vcenter.ViJson.OpenApi.Model.DistributedVirtualSwitchHostMemberHostPerfNicOffloadState

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **bool** | Indicates whether Performance NIC Offload is intended to be enabled on the host.  This property reflects the user&#39;s configuration intent. The actual runtime status of the feature is provided by *DistributedVirtualSwitchHostMemberHostPerfNicOffloadState.runtimeStatus*.  | 
**RuntimeStatus** | **string** | The runtime status of the Performance NIC Offload feature when *DistributedVirtualSwitchHostMemberHostPerfNicOffloadState.enabled* is true.  This property reflects whether the enablement request has succeeded, is in progress, or has failed. See *DistributedVirtualSwitchHostMemberHostPerfNicOffloadStateStatus_enum* for supported values.  | [optional] 
**StatusDescription** | **string** | A human-readable description providing additional details about the *DistributedVirtualSwitchHostMemberHostPerfNicOffloadState.runtimeStatus*.  This property is set if and only if *DistributedVirtualSwitchHostMemberHostPerfNicOffloadState.runtimeStatus* is FAILED.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

