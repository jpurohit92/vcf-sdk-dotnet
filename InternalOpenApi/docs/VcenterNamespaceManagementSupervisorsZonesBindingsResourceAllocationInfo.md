# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsZonesBindingsResourceAllocationInfo
The Vcenter.NamespaceManagement.Supervisors.Zones.Bindings.ResourceAllocationInfo schema contains information about resource allocation on a vSphere Zone associated with the Supervisor.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VmReservations** | [**List&lt;VcenterNamespaceManagementSupervisorsZonesBindingsVirtualMachineClassAllocationInfo&gt;**](VcenterNamespaceManagementSupervisorsZonesBindingsVirtualMachineClassAllocationInfo.md) | Identifier and quantities of Virtual Machines for which reservations are desired.  This property was added in __vSphere API 9.0.0.0__.  If unset vSphere Zone will have no Virtual Machine Class Instances reserved. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

