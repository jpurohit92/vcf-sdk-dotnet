# Vcenter.Automation.OpenApi.Model.VcenterAuthorizationRolesListItem
The Vcenter.Authorization.Roles.ListItem schema contains information about an authorization role in the vCenter Server.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Role** | **string** | The ID of the role.  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.authorization.Role&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.authorization.Role&#x60;. | 
**Info** | [**VcenterAuthorizationRolesInfo**](VcenterAuthorizationRolesInfo.md) | Information about the role.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

