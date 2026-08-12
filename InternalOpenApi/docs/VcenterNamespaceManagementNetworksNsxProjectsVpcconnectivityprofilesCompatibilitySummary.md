# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementNetworksNsxProjectsVpcconnectivityprofilesCompatibilitySummary
The Vcenter.NamespaceManagement.Networks.Nsx.Projects.Vpcconnectivityprofiles.Compatibility.Summary schema contains information about a VPC Connectivity Profile, including whether it is compatible with the Supervisor enablement feature and incompatibility reasons.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Profile** | **string** | Identifier of the VPC Connectivity Profile.  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;VpcConnectivityProfile&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;VpcConnectivityProfile&#x60;. | 
**Name** | **string** | User-friendly identifier of the VPC Connectivity Profile.  This property was added in __vSphere API 9.0.0.0__. | 
**NsxPath** | **string** | NSX path of the VPC Connectivity Profile.  This property was added in __vSphere API 9.0.0.0__. | 
**Compatible** | **bool** | Compatibility of this VPC Connectivity Profile with Supervisor enablement.  This property was added in __vSphere API 9.0.0.0__. | 
**IncompatibilityReasons** | [**List&lt;VapiStdLocalizableMessage&gt;**](VapiStdLocalizableMessage.md) | List of reasons for incompatibility. If *Vcenter.NamespaceManagement.Networks.Nsx.Projects.Vpcconnectivityprofiles.Compatibility.Summary.compatible* is true, this list will be empty.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

