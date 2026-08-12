# Vcenter.ViJson.OpenApi.Model.VmwareUplinkPortTeamingPolicy

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Inherited** | **bool** | Whether the configuration is set to inherited value.  | 
**Policy** | [**StringPolicy**](StringPolicy.md) | Network adapter teaming policy.  The policy defines the way traffic from the clients of the team is routed through the different uplinks in the team. The policies supported on the VDS platform is one of *nicTeamingPolicy*.  | [optional] 
**ReversePolicy** | [**BoolPolicy**](BoolPolicy.md) | The flag to indicate whether or not the teaming policy is applied to inbound frames as well.  Also see *HostNicTeamingPolicy.reversePolicy*  | [optional] 
**NotifySwitches** | [**BoolPolicy**](BoolPolicy.md) | Flag to specify whether or not to notify the physical switch if a link fails.  Also see *HostNicTeamingPolicy.notifySwitches*  | [optional] 
**RollingOrder** | [**BoolPolicy**](BoolPolicy.md) | The flag to indicate whether or not to use a rolling policy when restoring links.  Also see *HostNicTeamingPolicy.rollingOrder*  | [optional] 
**FailureCriteria** | [**DVSFailureCriteria**](DVSFailureCriteria.md) | Failover detection policy for the uplink port team.  | [optional] 
**UplinkPortOrder** | [**VMwareUplinkPortOrderPolicy**](VMwareUplinkPortOrderPolicy.md) | Failover order policy for uplink ports on the hosts.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

