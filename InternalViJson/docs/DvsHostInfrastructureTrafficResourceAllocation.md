# Vcenter.ViJson.OpenApi.Model.DvsHostInfrastructureTrafficResourceAllocation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Limit** | **long** | The maximum allowed usage for a traffic class belonging to this resource pool per host physical NIC.  The utilization of a traffic class will not exceed the specified limit even if there are available network resources. If this value is unset or set to -1 in an update operation, then there is no limit on the network resource usage (only bounded by available resource and shares). Units are in Mbits/sec.  | [optional] 
**Shares** | [**SharesInfo**](SharesInfo.md) | Network share.  The value is used as a relative weight in competing for shared bandwidth, in case of resource contention.  | [optional] 
**Reservation** | **long** | Amount of bandwidth resource that is guaranteed available to the host infrastructure traffic class.  If the utilization is less than the reservation, the extra bandwidth is used for other host infrastructure traffic class types. Reservation is not allowed to exceed the value of *DvsHostInfrastructureTrafficResourceAllocation.limit*, if *DvsHostInfrastructureTrafficResourceAllocation.limit* is set. Unit is Mbits/sec.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

