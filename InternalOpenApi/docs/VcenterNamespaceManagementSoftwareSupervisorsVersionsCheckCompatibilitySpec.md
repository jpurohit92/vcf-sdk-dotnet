# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSoftwareSupervisorsVersionsCheckCompatibilitySpec
The Vcenter.NamespaceManagement.Software.Supervisors.Versions.CheckCompatibilitySpec schema includes properties used to assess the compatibility of Supervisor version with a particular Cluster, Supervisor or list of Zones.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | **string** | The cluster ID for which the compatibility of Supervisor version is being checked.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, the field *Vcenter.NamespaceManagement.Software.Supervisors.Versions.CheckCompatibilitySpec.zones* or *Vcenter.NamespaceManagement.Software.Supervisors.Versions.CheckCompatibilitySpec.supervisor* should be specified.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;ClusterComputeResource&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;ClusterComputeResource&#x60;. | [optional] 
**Supervisor** | **string** | The Supervisor ID for which the compatibility of Supervisor version is being checked.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, the field *Vcenter.NamespaceManagement.Software.Supervisors.Versions.CheckCompatibilitySpec.cluster* or *Vcenter.NamespaceManagement.Software.Supervisors.Versions.CheckCompatibilitySpec.zones* should be specified.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.supervisor.Supervisor&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.supervisor.Supervisor&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

