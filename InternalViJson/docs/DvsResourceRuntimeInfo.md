# Vcenter.ViJson.OpenApi.Model.DvsResourceRuntimeInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Capacity** | **int** | Capacity: Total Reservation allocated for Virtual Machine Traffic for this switch.  Units in Mbits/s.  | [optional] 
**Usage** | **int** | usage: Current total usage.  This is the sum of all reservations allocated to *DVSVmVnicNetworkResourcePool* on this switch and the sum of reservation taken by *VirtualEthernetCard* whose backing is not associated with any *DVSVmVnicNetworkResourcePool*. Units in Mbits/s.  | [optional] 
**Available** | **int** | Available: Current available resource for reservation (capacity - usage).  Units in Mbits/s.  | [optional] 
**AllocatedResource** | [**List&lt;DvsVnicAllocatedResource&gt;**](DvsVnicAllocatedResource.md) | The reservation taken by *VirtualEthernetCard* of which the backing is not associated with any *DVSVmVnicNetworkResourcePool*  | [optional] 
**VmVnicNetworkResourcePoolRuntime** | [**List&lt;DvsVmVnicNetworkResourcePoolRuntimeInfo&gt;**](DvsVmVnicNetworkResourcePoolRuntimeInfo.md) | The runtime information of *DVSVmVnicNetworkResourcePool*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

