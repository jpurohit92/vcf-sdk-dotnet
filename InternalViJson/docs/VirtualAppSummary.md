# Vcenter.ViJson.OpenApi.Model.VirtualAppSummary

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of resource pool.  | 
**Config** | [**ResourceConfigSpec**](ResourceConfigSpec.md) | Current configuration of the resource pool.  | 
**Runtime** | [**ResourcePoolRuntimeInfo**](ResourcePoolRuntimeInfo.md) | Current runtime state of the resource pool.  | 
**QuickStats** | [**ResourcePoolQuickStats**](ResourcePoolQuickStats.md) | A set of statistics that are typically updated with near real-time regularity.  This data object type does not support notification, for scalability reasons. Therefore, changes in QuickStats do not generate property collector updates. To monitor statistics values, use the statistics and alarms modules instead.  | [optional] 
**ConfiguredMemoryMB** | **int** | Total configured memory of all virtual machines in the resource pool, in MB.  | [optional] 
**Product** | [**VAppProductInfo**](VAppProductInfo.md) | Product information.  References to properties in the URLs are expanded.  | [optional] 
**VAppState** | **VirtualAppVAppStateEnum** | Whether the vApp is running  | [optional] 
**Suspended** | **bool** | Whether a vApp is suspended, in the process of being suspended, or in the process of being resumed.  A stopped vApp is marked as suspended under the following conditions: - All child virtual machines are either suspended or powered-off. - There is at least one suspended virtual machine for which the   stop action is not \&quot;suspend\&quot;.    If the vAppState property is \&quot;stopped\&quot;, the value is set to true if the vApp is suspended (according the the above definition).  If the vAppState property is \&quot;stopping\&quot; or \&quot;starting\&quot; and the suspend flag is set to true, then the vApp is either in the process of being suspended or resumed from a suspended state, respectively.  If the vAppState property is \&quot;started\&quot;, then the suspend flag is set to false.  | [optional] 
**InstallBootRequired** | **bool** | Whether one or more VMs in this vApp require a reboot to finish installation.  | [optional] 
**InstanceUuid** | **string** | vCenter-specific UUID of the vApp  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

