# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsZonesBindingsResourceAllocationSpec
The Vcenter.NamespaceManagement.Supervisors.Zones.Bindings.ResourceAllocationSpec schema contains configuration of resources on a vSphere Zone associated with the Supervisor.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VmReservations** | [**List&lt;VcenterNamespaceManagementSupervisorsZonesBindingsVirtualMachineClassAllocationSpec&gt;**](VcenterNamespaceManagementSupervisorsZonesBindingsVirtualMachineClassAllocationSpec.md) | Identifier and quantities of Virtual Machine Classes for which instances should be reserved.  This property was added in __vSphere API 9.0.0.0__.  If unset vSphere Zone will have no Virtual Machine Class Instances reserved. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

