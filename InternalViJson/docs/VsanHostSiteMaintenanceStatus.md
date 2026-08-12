# Vcenter.ViJson.OpenApi.Model.VsanHostSiteMaintenanceStatus

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | Target host.  Refers instance of *HostSystem*.  | 
**State** | **string** | The fault domain maintenance state of the host; unset if the host is not connected.  See also *VsanSiteMaintenanceState_enum*.  | [optional] 
**StartTime** | **DateTime** | Represents the start time of the fault domain maintenance operation that places the host into fault domain maintenance mode, if the host is already in fault domain maintenance mode; otherwise it will be left as unset.  | [optional] 
**HostCount** | **long** | If the host is in fault domain maintenance mode, this attribute represents the number of hosts involved in the fault domain maintenance operation that placed the host into maintenance mode; otherwise it will be left as unset.  | [optional] 
**Hosts** | **List&lt;string&gt;** | If the host is in fault domain maintenance mode, this attribute represents the UUIDs of hosts involved in the fault domain maintenance operation that placed the host into maintenance mode; otherwise it will be left as unset.  | [optional] 
**StatusUpdateTime** | **long** | Represents the timestamp of the most recent fault domain maintenance status update which could be triggered by both vCenter and hosts.  If the host was never in fault domain maintenance mode, it will be left as unset. Unit in nanosecond.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

