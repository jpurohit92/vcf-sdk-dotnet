# Vcenter.ViJson.OpenApi.Model.ClusterDasFailoverLevelAdvancedRuntimeInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DasHostInfo** | [**ClusterDasHostInfo**](ClusterDasHostInfo.md) | The information pertaining to the HA agents on the hosts  | [optional] 
**VmcpSupported** | [**ClusterDasAdvancedRuntimeInfoVmcpCapabilityInfo**](ClusterDasAdvancedRuntimeInfoVmcpCapabilityInfo.md) | Whether HA VM Component Protection can be enabled for the cluster.  | [optional] 
**HeartbeatDatastoreInfo** | [**List&lt;DasHeartbeatDatastoreInfo&gt;**](DasHeartbeatDatastoreInfo.md) | The map of a datastore to the set of hosts that are using the datastore for storage heartbeating.  | [optional] 
**SlotInfo** | [**ClusterDasFailoverLevelAdvancedRuntimeInfoSlotInfo**](ClusterDasFailoverLevelAdvancedRuntimeInfoSlotInfo.md) | Slot information for this cluster.  | 
**TotalSlots** | **int** | The total number of slots available in the cluster.  See also *ClusterDasFailoverLevelAdvancedRuntimeInfoSlotInfo*.  | 
**UsedSlots** | **int** | The number of slots currently being used.  See also *ClusterDasFailoverLevelAdvancedRuntimeInfoSlotInfo*.  | 
**UnreservedSlots** | **int** | The number of slots that are not used by currently powered on virtual machines and not reserved to satisfy the configured failover level.  This number gives an indication of how many additional virtual machines can be powered on in this cluster without violating the failover level (assuming the new virtual machine&#39;s reservations are satisfied by the current slot size). This value is computed as follows (where m is the configured failover level): Remove the m largest hosts (ie. the ones with the most slots) from the list of \&quot;good\&quot; hosts (see *ClusterDasFailoverLevelAdvancedRuntimeInfo.totalGoodHosts*). Sum up the number of slots on the remaining hosts and deduct the number of currently used slots (see *ClusterDasFailoverLevelAdvancedRuntimeInfo.usedSlots*). If this number is negative, use zero instead.  See also *ClusterDasFailoverLevelAdvancedRuntimeInfoSlotInfo*.  | 
**TotalVms** | **int** | The total number of powered on vms in the cluster.  | 
**TotalHosts** | **int** | The total number of hosts in the cluster.  | 
**TotalGoodHosts** | **int** | The total number of connected hosts that are not in maintenance mode and that do not have any DAS-related config issues on them.  | 
**HostSlots** | [**List&lt;ClusterDasFailoverLevelAdvancedRuntimeInfoHostSlots&gt;**](ClusterDasFailoverLevelAdvancedRuntimeInfoHostSlots.md) |  | [optional] 
**VmsRequiringMultipleSlots** | [**List&lt;ClusterDasFailoverLevelAdvancedRuntimeInfoVmSlots&gt;**](ClusterDasFailoverLevelAdvancedRuntimeInfoVmSlots.md) | The list of virtual machines whose reservations and memory overhead are not satisfied by a single slot.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

