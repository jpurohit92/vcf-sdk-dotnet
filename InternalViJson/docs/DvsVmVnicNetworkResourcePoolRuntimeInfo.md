# Vcenter.ViJson.OpenApi.Model.DvsVmVnicNetworkResourcePoolRuntimeInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | The key of the virtual NIC network resource pool  | 
**Name** | **string** | The name of the virtual NIC network resource pool  | [optional] 
**Capacity** | **int** | Capacity: Reservation allocated for this Network Resource Pool.  Units in Mbits/s.  | [optional] 
**Usage** | **int** | usage: Reservation taken by all *VirtualEthernetCard* for which the backing is associated with this *DVSVmVnicNetworkResourcePool*.  Units in Mbits/s.  | [optional] 
**Available** | **int** | Available: Current available resource for reservation (capacity - usage).  Units in Mbits/s.  | [optional] 
**Status** | **string** | The status of the virtual NIC network resource pool See *ManagedEntityStatus_enum* for possible values  *red* indicates that the reservations used by all the virtual network adapters belonging to this resource pool exceeds the total reservation quota allocated to the resource pool. This can happen due to failure of one or more uplink or if the user bypasses VirtualCenter and powers on VMs directly on host. The reservation of one or more virtual network adapters cannot be guaranteed and corrective action needs to be taken by the user.  *green* indicates that the resource pool is in good state. The reservations for all virtual network adapters can be fulfilled.  | 
**AllocatedResource** | [**List&lt;DvsVnicAllocatedResource&gt;**](DvsVnicAllocatedResource.md) | The virtual network adapters that are currently associated with the resource pool  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

