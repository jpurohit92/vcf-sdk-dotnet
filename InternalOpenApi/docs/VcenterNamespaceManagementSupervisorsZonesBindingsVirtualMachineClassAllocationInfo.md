# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsZonesBindingsVirtualMachineClassAllocationInfo
The Vcenter.NamespaceManagement.Supervisors.Zones.Bindings.VirtualMachineClassAllocationInfo schema contains information describing desired allocation.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClusterAllocation** | [**Dictionary&lt;string, VcenterNamespaceManagementSupervisorsZonesBindingsVirtualMachineClassCapacityInfo&gt;**](VcenterNamespaceManagementSupervisorsZonesBindingsVirtualMachineClassCapacityInfo.md) | A list of vSphere Cluster identifiers in a vSphere Zone and capacities of the Virtual Machine class in each vSphere Cluster  This property was added in __vSphere API 9.1.0.0__.  If unset the Virtual Machine Class is not allocated to a vSphere Cluster in a vSphere Zone.  When clients pass a value of this schema as a parameter, the key in the property map must be an identifier for the resource type: &#x60;ClusterComputeResource&#x60;. When operations return a value of this schema as a response, the key in the property map will be an identifier for the resource type: &#x60;ClusterComputeResource&#x60;. | [optional] 
**ReservedVmClass** | **string** | Identifier of the Virtual Machine class used for allocation.  This property was added in __vSphere API 9.0.0.0__. | 
**Count** | **long** | Number of instances of given Virtual Machine class.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

