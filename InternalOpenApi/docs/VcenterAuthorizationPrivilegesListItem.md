# Vcenter.Automation.OpenApi.Model.VcenterAuthorizationPrivilegesListItem
The Vcenter.Authorization.Privileges.ListItem schema contains information about an authorization privilege in the vCenter Server.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Privilege** | **string** | The ID of the privilege.  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.authorization.Privilege&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.authorization.Privilege&#x60;. | 
**Info** | [**VcenterAuthorizationPrivilegesInfo**](VcenterAuthorizationPrivilegesInfo.md) | Information about the privilege.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

