# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorServicesVersionsInfo
The Vcenter.NamespaceManagement.SupervisorServices.Versions.Info schema contains detailed information about a Supervisor Service version.  This schema was added in __vSphere API 7.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | The human readable name of the Supervisor Service version.  This property was added in __vSphere API 7.0.3.0__. | 
**Description** | **string** | A human-readable description of the Supervisor Service version.  This property was added in __vSphere API 7.0.3.0__.  If missing or &#x60;null&#x60;, no description is available for the Supervisor Service version. | [optional] 
**Eula** | **string** | The End User License Agreement (EULA) associated with the Supervisor Service version.  This property was added in __vSphere API 7.0.3.0__.  If missing or &#x60;null&#x60;, no EULA is available for the Supervisor Service version. | [optional] 
**ContentType** | **string** | The content type of content.  Possible values:   - &#x60;VSPHERE_APPS_YAML&#x60;: The Supervisor Service version definition is provided as inline YAML document that follows the vSphere application service format.   - &#x60;CARVEL_APPS_YAML&#x60;: The Supervisor Service version definition is provided as inline YAML document that follows the Carvel application package format.  This constant was added in __vSphere API 8.0.0.1__.   - &#x60;CUSTOM_YAML&#x60;: The Supervisor Service version definition is provided as inline YAML document that follows a plain Kubernetes YAML format.   For more information see: *Vcenter.NamespaceManagement.SupervisorServices.Versions.ContentType*.  This property was added in __vSphere API 7.0.3.0__. | 
**Content** | **string** | Inline content that contains base64 encoded service definition for the version.  This property was added in __vSphere API 7.0.3.0__.  If missing or &#x60;null&#x60;, no content is available for the Supervisor Service version. | [optional] 
**TrustVerified** | **bool** | If true, the Supervisor Service version is from trusted provider and the trust is verified.  This property was added in __vSphere API 7.0.3.0__. | 
**State** | **string** | The current Vcenter.NamespaceManagement.SupervisorServices.Versions.State of the version.  Possible values:   - &#x60;ACTIVATED&#x60;: The is the default state of a Supervisor Service version upon creation. In this state, all operations on the version should work as normal.   - &#x60;DEACTIVATED&#x60;: The is the deactivated state of a Supervisor Service version. In this state, certain operations on the version are disallowed, for example, the version cannot be created on the vSphere Supervisor clusters.   For more information see: *Vcenter.NamespaceManagement.SupervisorServices.Versions.State*.  This property was added in __vSphere API 7.0.3.0__. | 
**RegisteredByDefault** | **bool** | If &#x60;true&#x60;, this Supervisor Service version has been registered on vCenter by default and cannot be removed. If &#x60;false&#x60;, this service version has been registered by an administrator.  This property was added in __vSphere API 8.0.3.0__.  This property is optional because it was added in a newer version than its parent node. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

