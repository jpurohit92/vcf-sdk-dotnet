# Vcenter.ViJson.OpenApi.Model.HostMemberRuntimeInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | The host.  Refers instance of *HostSystem*.  | 
**Status** | **string** | Host proxy switch status.  See *HostComponentState* for valid values. This property replaces the deprecated *DistributedVirtualSwitchHostMember*.*DistributedVirtualSwitchHostMember.status*.  | [optional] 
**StatusDetail** | **string** | Additional information regarding the current membership status of the host.  This property replaces the deprecated *DistributedVirtualSwitchHostMember*.*DistributedVirtualSwitchHostMember.statusDetail*.  | [optional] 
**NsxtStatus** | **string** | NSX-T component status.  | [optional] 
**NsxtStatusDetail** | **string** | Additional information regarding the NSX-T component status.  | [optional] 
**HealthCheckResult** | [**List&lt;HostMemberHealthCheckResult&gt;**](HostMemberHealthCheckResult.md) | Health check result for the host that joined the distributed virtual switch.  | [optional] 
**HostUplinkState** | [**List&lt;DistributedVirtualSwitchHostMemberHostUplinkState&gt;**](DistributedVirtualSwitchHostMemberHostUplinkState.md) | Indicate the runtime state of uplink on the host.  It is only applicable when *DistributedVirtualSwitchHostMemberConfigInfo.networkOffloadingEnabled* is true.  ***Since:*** vSphere API Release 8.0.3.0  | [optional] 
**HostPerfNicOffloadState** | [**DistributedVirtualSwitchHostMemberHostPerfNicOffloadState**](DistributedVirtualSwitchHostMemberHostPerfNicOffloadState.md) | Indicates the runtime state of the performance NIC offloading on the host.  If unset, performance NIC offloading is considered disabled.  ***Since:*** vSphere API Release 9.1.0.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

