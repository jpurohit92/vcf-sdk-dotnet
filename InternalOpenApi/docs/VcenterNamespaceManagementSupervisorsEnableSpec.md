# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsEnableSpec
  The Vcenter.NamespaceManagement.Supervisors.EnableSpec schema contains the specification required to enable a Supervisor.   The ability to add multiple workload networks at enablement has been deprecated. Please use the *Vcenter.NamespaceManagement.Networks* APIs to add additional workload networks after the cluster has been enabled.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | A *Vcenter.NamespaceManagement.Supervisors.EnableSpec.name* is a user-friendly identifier for this Supervisor.  This property was added in __vSphere API 8.0.0.1__. | 
**ControlPlane** | [**VcenterNamespaceManagementSupervisorsControlPlane**](VcenterNamespaceManagementSupervisorsControlPlane.md) | *Vcenter.NamespaceManagement.Supervisors.EnableSpec.control_plane* specifies configuration for the Supervisor control plane.  This property was added in __vSphere API 8.0.0.1__. | 
**Workloads** | [**VcenterNamespaceManagementSupervisorsWorkloads**](VcenterNamespaceManagementSupervisorsWorkloads.md) | *Vcenter.NamespaceManagement.Supervisors.EnableSpec.workloads* specifies configuration for compute, network, and storage for workloads.  This property was added in __vSphere API 8.0.0.1__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

