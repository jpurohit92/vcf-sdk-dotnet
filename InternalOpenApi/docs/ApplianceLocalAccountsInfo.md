# Vcenter.Automation.OpenApi.Model.ApplianceLocalAccountsInfo
The Appliance.LocalAccounts.Info schema defines the local account properties.  This schema was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Fullname** | **string** | Full name of the user  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60;, the value was never set. | [optional] 
**Email** | **string** | Email address of the local account  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60;, the value was never set. | [optional] 
**Roles** | **List&lt;string&gt;** | User roles  This property was added in __vSphere API 6.7__.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;com.vmware.appliance.roles&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;com.vmware.appliance.roles&#x60;. | 
**Enabled** | **bool** | Flag indicating if the account is enabled  This property was added in __vSphere API 6.7__. | 
**HasPassword** | **bool** | Is the user password set.  This property was added in __vSphere API 6.7__. | 
**LastPasswordChange** | **DateTime** | Date and time password was changed.  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60;, the password was never set. | [optional] 
**PasswordExpiresAt** | **DateTime** | Date when the account&#39;s password will expire  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60;, the password never expires. | [optional] 
**InactiveAt** | **DateTime** | Date and time account will be locked after password expiration.  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60;, account will not be locked. | [optional] 
**MinDaysBetweenPasswordChange** | **long** | Minimum number of days between password change  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60;, pasword can be changed any time. | [optional] 
**MaxDaysBetweenPasswordChange** | **long** | Maximum number of days between password change  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60;, password never expires. | [optional] 
**WarnDaysBeforePasswordExpiration** | **long** | Number of days of warning before password expires  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60;, a user is never warned. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

