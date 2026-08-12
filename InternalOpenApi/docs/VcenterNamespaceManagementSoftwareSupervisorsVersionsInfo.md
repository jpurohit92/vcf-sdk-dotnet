# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSoftwareSupervisorsVersionsInfo
The Vcenter.NamespaceManagement.Software.Supervisors.Versions.Info schema contains the detailed information about a Supervisor version.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VarVersion** | **string** | Identifier for the Supervisor version.  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;SupervisorVersion&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;SupervisorVersion&#x60;. | 
**Name** | **string** | Name of the Supervisor release.  This property was added in __vSphere API 9.0.0.0__. | 
**Description** | **string** | Description of the Supervisor release.  This property was added in __vSphere API 9.0.0.0__. | 
**ReleaseDate** | **DateTime** | Date of Supervisor release.  This property was added in __vSphere API 9.0.0.0__. | 
**ReleaseNotes** | **string** | Details of Supervisor release.  This property was added in __vSphere API 9.0.0.0__. | 
**ImageSourceSpecs** | [**List&lt;VcenterNamespaceManagementSupervisorsImageSourceSpec&gt;**](VcenterNamespaceManagementSupervisorsImageSourceSpec.md) | Details about the source of Supervisor image.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

