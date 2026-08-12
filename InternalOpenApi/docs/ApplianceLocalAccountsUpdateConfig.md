# Vcenter.Automation.OpenApi.Model.ApplianceLocalAccountsUpdateConfig
The Appliance.LocalAccounts.UpdateConfig schema defines the fields that might be updated.  This schema was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Password** | **string** | Password  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60;, value will not be changed | [optional] 
**OldPassword** | **string** | Old password of the user (required in case of the password change, not required if superAdmin user changes the password of the other user)  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60;, user may not have password set. | [optional] 
**FullName** | **string** | Full name of the user  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60;, value will not be changed | [optional] 
**Email** | **string** | Email address of the local account  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60;, value will not be changed | [optional] 
**Roles** | **List&lt;string&gt;** | User roles  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60;, value will not be changed  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;com.vmware.appliance.roles&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;com.vmware.appliance.roles&#x60;. | [optional] 
**Enabled** | **bool** | Flag indicating if the account is enabled  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60;, value will not be changed | [optional] 
**PasswordExpires** | **bool** | Flag indicating if the account password expires  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60;, value will not be changed | [optional] 
**PasswordExpiresAt** | **DateTime** | Date when the account&#39;s password will expire  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60;, value will not be changed | [optional] 
**InactiveAfterPasswordExpiration** | **bool** | Flag indicating if the account will be locked after password expiration  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60;, value will not be changed | [optional] 
**DaysAfterPasswordExpiration** | **long** | Number of days after password expiration before the account will be locked  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60;, value will not be changed | [optional] 
**MinDaysBetweenPasswordChange** | **long** | Minimum number of days between password change  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60;, value will not be changed | [optional] 
**MaxDaysBetweenPasswordChange** | **long** | Maximum number of days between password change  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60;, value will not be changed | [optional] 
**WarnDaysBeforePasswordExpiration** | **long** | Number of days of warning before password expires  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60;, value will not be changed | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

