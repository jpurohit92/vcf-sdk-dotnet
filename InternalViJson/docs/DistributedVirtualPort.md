# Vcenter.ViJson.OpenApi.Model.DistributedVirtualPort

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | Port key.  | 
**Config** | [**DVPortConfigInfo**](DVPortConfigInfo.md) | Port configuration, including identifying information, network settings, and the set of entities that can connect to the port.  | 
**DvsUuid** | **string** | UUID of the *DistributedVirtualSwitch* to which the port belongs.  | 
**PortgroupKey** | **string** | Key of the portgroup *DistributedVirtualPortgroup* to which the port belongs, if any.  | [optional] 
**ProxyHost** | [**ManagedObjectReference**](ManagedObjectReference.md) | *HostSystem* that services this port.  Refers instance of *HostSystem*.  | [optional] 
**Connectee** | [**DistributedVirtualSwitchPortConnectee**](DistributedVirtualSwitchPortConnectee.md) | Entity that connects to the port.  | [optional] 
**Conflict** | **bool** | Specifies whether the port is a conflict port.  A port could be marked as conflict if an entity is discovered connecting to a port that is already occupied, or if the host creates a port without conferring with vCenter Server.  The distributed virtual switch does not persist the runtime state of a conflict port. Also, the port cannot move away from the host. vCenter Server will not move a virtual machine (VMotion) that is using a conflict port.  | 
**ConflictPortKey** | **string** | If the port is marked conflict in the case of two entities connecting to the same port (see *DistributedVirtualPort.conflict*), this is the key of the port which the connected entity is contending for.  | [optional] 
**State** | [**DVPortState**](DVPortState.md) | Runtime state of the port.  | [optional] 
**ConnectionCookie** | **int** | Cookie representing the current instance of association between a port and a virtual or physical NIC.  See *DistributedVirtualSwitchPortConnection*. The same cookie is present in the physical or virtual NIC configuration (*DistributedVirtualSwitchPortConnection*.*DistributedVirtualSwitchPortConnection.connectionCookie*) so that the Server can verify that the entity is the rightful connectee of the port.  | [optional] 
**LastStatusChange** | **DateTime** | The last time the *DistributedVirtualPort.state*.*DVPortState.runtimeInfo* value was changed.  | 
**HostLocalPort** | **bool** | Specifies whether the port is a host local port.  A host local port is created to resurrect the management network connection on a VMkernel virtual NIC. You cannot use vCenter Server to reconfigure this port and you cannot reassign the port.  | [optional] 
**ExternalId** | **string** | Populate the Id assigned to vmknic or vnic by external management plane to port, if the port is connected to the nics.  | [optional] 
**SegmentPortId** | **string** | Populate the segmentPortId assigned to LSP.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

