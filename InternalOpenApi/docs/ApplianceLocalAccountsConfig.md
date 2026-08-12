# Vcenter.Automation.OpenApi.Model.ApplianceLocalAccountsConfig
The Appliance.LocalAccounts.Config schema defines the information required for the account.  This schema was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Password** | **string** | Password  This property was added in __vSphere API 6.7__. | 
**OldPassword** | **string** | Old password of the user (required in case of the password change, not required if superAdmin user changes the password of the other user)  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60;, user may not have password set. | [optional] 
**FullName** | **string** | Full name of the user  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60;, user will have no fullname. | [optional] 
**Email** | **string** | Email address of the local account  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60;, user will have no email. | [optional] 
**Roles** | **List&lt;string&gt;** | User roles  This property was added in __vSphere API 6.7__.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;com.vmware.appliance.roles&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;com.vmware.appliance.roles&#x60;. | 
**Enabled** | **bool** | Flag indicating if the account is enabled  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60;, defaults to True | [optional] 
**PasswordExpires** | **bool** | Flag indicating if the account password expires  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60;, defaults to True. | [optional] 
**PasswordExpiresAt** | **DateTime** | Date when the account&#39;s password will expire  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60;, will be taken from system defaults (see local-accounts/policy). | [optional] 
**InactiveAfterPasswordExpiration** | **bool** | Flag indicating if the account will be locked after password expiration  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60;, defaults to True. | [optional] 
**DaysAfterPasswordExpiration** | **long** | Number of days after password expiration before the account will be locked  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60;, will be taken from system defaults (see local-accounts/policy). | [optional] 
**MinDaysBetweenPasswordChange** | **long** | Minimum number of days between password change  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60;, will be taken from system defaults (see local-accounts/policy). | [optional] 
**MaxDaysBetweenPasswordChange** | **long** | Maximum number of days between password change  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60;, will be taken from system defaults (see local-accounts/policy). | [optional] 
**WarnDaysBeforePasswordExpiration** | **long** | Number of days of warning before password expires  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60;, will be taken from system defaults (see local-accounts/policy). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

