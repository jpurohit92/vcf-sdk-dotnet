# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementNetworksNsxProjectsVpcsInfo
The Vcenter.NamespaceManagement.Networks.Nsx.Projects.Vpcs.Info schema contains the basic information about a VPC.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vpc** | **string** | Identifier of the VPC.  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.networks.nsx.Vpc&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.networks.nsx.Vpc&#x60;. | 
**Name** | **string** | Human-readable identifier of the VPC.  This property was added in __vSphere API 9.0.0.0__. | 
**NsxPath** | **string** | NSX path of the VPC.  This property was added in __vSphere API 9.0.0.0__. | 
**VpcConnectivityProfile** | **string** | VPC Connectivity Profile of the VPC.  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;VpcConnectivityProfile&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;VpcConnectivityProfile&#x60;. | 
**PrivateIps** | **List&lt;string&gt;** | Private IPs of the VPC.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

