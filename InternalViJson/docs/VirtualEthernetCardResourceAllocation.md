# Vcenter.ViJson.OpenApi.Model.VirtualEthernetCardResourceAllocation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Reservation** | **long** | Amount of network bandwidth that is guaranteed to the virtual network adapter.  If utilization is less than reservation, the resource can be used by other virtual network adapters. Reservation is not allowed to exceed the value of *VirtualEthernetCardResourceAllocation.limit* if *VirtualEthernetCardResourceAllocation.limit* is set. Units in Mbits/sec.  | [optional] 
**Share** | [**SharesInfo**](SharesInfo.md) | Network share.  The value is used as a relative weight in competing for shared bandwidth, in case of resource contention.  | 
**Limit** | **long** | The bandwidth limit for the virtual network adapter.  The utilization of the virtual network adapter will not exceed this limit, even if there are available resources. To clear the value of this property and revert it to unset, set the value to \&quot;-1\&quot; in an update operation. Units in Mbits/sec.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

