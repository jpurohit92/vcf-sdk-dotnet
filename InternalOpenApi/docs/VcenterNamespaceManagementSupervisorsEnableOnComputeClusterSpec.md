# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsEnableOnComputeClusterSpec
  The Vcenter.NamespaceManagement.Supervisors.EnableOnComputeClusterSpec schema contains the specification required to enable a Supervisor on a vSphere cluster.   The ability to add multiple workload networks at enablement has been deprecated. Please use the *Vcenter.NamespaceManagement.Networks* APIs to add additional workload networks after the cluster has been enabled.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Zone** | **string** | *Vcenter.NamespaceManagement.Supervisors.EnableOnComputeClusterSpec.zone* describes consumption fault domain zone available to the Supervisor and its workloads.  This property was added in __vSphere API 8.0.0.1__.  Zone will be created and associated with the cluster. If missing or &#x60;null&#x60;, the zone name will be generated based on the cluster managed object ID. The zone can be managed with the consumption fault domain zone api.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.consumption_domains.Zone&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.consumption_domains.Zone&#x60;. | [optional] 
**Name** | **string** | A *Vcenter.NamespaceManagement.Supervisors.EnableSpec.name* is a user-friendly identifier for this Supervisor.  This property was added in __vSphere API 8.0.0.1__. | 
**ControlPlane** | [**VcenterNamespaceManagementSupervisorsControlPlane**](VcenterNamespaceManagementSupervisorsControlPlane.md) | *Vcenter.NamespaceManagement.Supervisors.EnableSpec.control_plane* specifies configuration for the Supervisor control plane.  This property was added in __vSphere API 8.0.0.1__. | 
**Workloads** | [**VcenterNamespaceManagementSupervisorsWorkloads**](VcenterNamespaceManagementSupervisorsWorkloads.md) | *Vcenter.NamespaceManagement.Supervisors.EnableSpec.workloads* specifies configuration for compute, network, and storage for workloads.  This property was added in __vSphere API 8.0.0.1__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

