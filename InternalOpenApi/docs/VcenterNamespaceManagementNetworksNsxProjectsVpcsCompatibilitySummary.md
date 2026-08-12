# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementNetworksNsxProjectsVpcsCompatibilitySummary
The Vcenter.NamespaceManagement.Networks.Nsx.Projects.Vpcs.Compatibility.Summary schema contains information about a Project, including whether it is compatible with the vCenter Namespaces feature and incompatibility reasons.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vpc** | **string** | Identifier of the VPC.  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.networks.nsx.Vpc&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.networks.nsx.Vpc&#x60;. | 
**Name** | **string** | User-friendly identifier of the VPC.  This property was added in __vSphere API 9.0.0.0__. | 
**NsxPath** | **string** | NSX path of the VPC.  This property was added in __vSphere API 9.0.0.0__. | 
**Compatible** | **bool** | Compatibility of this VPC with the given Supervisor.  This property was added in __vSphere API 9.0.0.0__. | 
**IncompatibilityReasons** | [**List&lt;VapiStdLocalizableMessage&gt;**](VapiStdLocalizableMessage.md) | List of reasons for incompatibility. If *Vcenter.NamespaceManagement.Networks.Nsx.Projects.Vpcs.Compatibility.Summary.compatible* is true, this list will be empty.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

