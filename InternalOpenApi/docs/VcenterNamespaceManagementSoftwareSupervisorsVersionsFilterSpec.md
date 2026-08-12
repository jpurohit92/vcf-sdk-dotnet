# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSoftwareSupervisorsVersionsFilterSpec
A FilterSpec allows listing the compatible versions of a Supervisor for enablement given the set of constraints.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClusterComputeResource** | **string** | The vSphere cluster for which the compatibility of Supervisor version is being checked.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, zone based lookup is performed.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;ClusterComputeResource&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;ClusterComputeResource&#x60;. | [optional] 
**NetworkProvider** | **string** | The cluster networking mode for the Supervisor.  Possible values:   - &#x60;NSXT_CONTAINER_PLUGIN&#x60;: Provider for NSX Networking.   - &#x60;VSPHERE_NETWORK&#x60;: Provider for vSphere Networking.   - &#x60;NSX_VPC&#x60;: Provider for NSX VPC Networking.   For more information see: *Vcenter.NamespaceManagement.Software.Supervisors.Versions.NetworkProvider*.  This property was added in __vSphere API 9.1.0.0__.  If not provided, network provider will not be considered in the compatibility check. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

