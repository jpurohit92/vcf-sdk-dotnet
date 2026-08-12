# Vcenter.Automation.OpenApi.Model.VcenterAuthorizationPrivilegesInfo
The Vcenter.Authorization.Privileges.Info schema contains detailed information about a specific privilege.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the privilege. It matches completely with the ID of the privilege.  This property was added in __vSphere API 9.0.0.0__. | 
**Description** | **string** | A brief summary what this privilege is dedicated for.  This property was added in __vSphere API 9.0.0.0__. | 
**OnParent** | **bool** | Indicates whether the privilege needs to apply on parent object as well.  This property was added in __vSphere API 9.0.0.0__. | 
**VarVersion** | **long** | The latest version of the privilege. Default version when the privilege is created is 0. If privilege is modified this counter is increased.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

