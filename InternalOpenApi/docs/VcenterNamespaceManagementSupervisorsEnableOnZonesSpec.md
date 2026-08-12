# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsEnableOnZonesSpec
  The Vcenter.NamespaceManagement.Supervisors.EnableOnZonesSpec schema contains the specification required to enable the Supervisor on a set of vSphere Zones.   The ability to add multiple workload networks at enablement has been deprecated. Please use the *Vcenter.NamespaceManagement.Networks* APIs to add additional workload networks after the cluster has been enabled.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Zones** | **List&lt;string&gt;** | *Vcenter.NamespaceManagement.Supervisors.EnableOnZonesSpec.zones* describe consumption fault domain zones available to the Supervisor and its workloads. Only one or three zones are supported.  This property was added in __vSphere API 8.0.0.1__.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;com.vmware.vcenter.consumption_domains.Zone&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;com.vmware.vcenter.consumption_domains.Zone&#x60;. | 
**Name** | **string** | A *Vcenter.NamespaceManagement.Supervisors.EnableSpec.name* is a user-friendly identifier for this Supervisor.  This property was added in __vSphere API 8.0.0.1__. | 
**ControlPlane** | [**VcenterNamespaceManagementSupervisorsControlPlane**](VcenterNamespaceManagementSupervisorsControlPlane.md) | *Vcenter.NamespaceManagement.Supervisors.EnableSpec.control_plane* specifies configuration for the Supervisor control plane.  This property was added in __vSphere API 8.0.0.1__. | 
**Workloads** | [**VcenterNamespaceManagementSupervisorsWorkloads**](VcenterNamespaceManagementSupervisorsWorkloads.md) | *Vcenter.NamespaceManagement.Supervisors.EnableSpec.workloads* specifies configuration for compute, network, and storage for workloads.  This property was added in __vSphere API 8.0.0.1__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

