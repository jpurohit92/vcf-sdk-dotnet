# Vcenter.ViJson.OpenApi.Model.HostNicTeamingPolicy

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Policy** | **string** | Network adapter teaming policy includes failover and load balancing, It can be one of the following: - **loadbalance\\_ip**: route based on ip hash. - **loadbalance\\_srcmac**: route based on source MAC hash. - **loadbalance\\_srcid**: route based on the source of the port ID. - **failover\\_explicit**: use explicit failover order.    See also *HostNetCapabilities.nicTeamingPolicy*.  | [optional] 
**ReversePolicy** | **bool** | Deprecated as of VI API 5.1, the system default (true) will be used.  The flag to indicate whether or not the teaming policy is applied to inbound frames as well.  For example, if the policy is explicit failover, a broadcast request goes through uplink1 and comes back through uplink2. Then if the reverse policy is set, the frame is dropped when it is received from uplink2. This reverse policy is useful to prevent the virtual machine from getting reflections.  | [optional] 
**NotifySwitches** | **bool** | Flag to specify whether or not to notify the physical switch if a link fails.  If this property is true, ESX Server will respond to the failure by sending a RARP packet from a different physical adapter, causing the switch to update its cache.  | [optional] 
**RollingOrder** | **bool** | The flag to indicate whether or not to use a rolling policy when restoring links.  For example, assume the explicit link order is (vmnic9, vmnic0), therefore vmnic9 goes down, vmnic0 comes up. However, when vmnic9 comes backup, if rollingOrder is set to be true, vmnic0 continues to be used, otherwise, vmnic9 is restored as specified in the explicitly order.  | [optional] 
**FailureCriteria** | [**HostNicFailureCriteria**](HostNicFailureCriteria.md) | Failover detection policy for this network adapter team.  The bridge must be BondBridge for this property to be valid.  | [optional] 
**NicOrder** | [**HostNicOrderPolicy**](HostNicOrderPolicy.md) | Failover order policy for network adapters on this switch.  The bridge must be BondBridge for this property to be valid.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

