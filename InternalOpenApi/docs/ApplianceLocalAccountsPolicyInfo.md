# Vcenter.Automation.OpenApi.Model.ApplianceLocalAccountsPolicyInfo
The Appliance.LocalAccounts.Policy.Info schema defines the global password policy.  This schema was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MaxDays** | **long** | Maximum number of days a password may be used. If the password is older than this, a password change will be forced.  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60; then the restriction will be ignored. This updates the global settings for the new users as well as the existing users. To update the settings for a particular user, PATCH /api/appliance/local-accounts/{username} API can be used | [optional] 
**MinDays** | **long** | Minimum number of days allowed between password changes. Any password changes attempted sooner than this will be rejected.  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60; then the restriction will be ignored. This updates the global settings for the new users as well as the existing users. To update the settings for a particular user, PATCH /api/appliance/local-accounts/{username} API can be used | [optional] 
**WarnDays** | **long** | Number of days warning given before a password expires. A zero means warning is given only upon the day of expiration.  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60; then no warning will be provided. This updates the global settings for the new users as well as the existing users. To update the settings for a particular user, PATCH /api/appliance/local-accounts/{username} API can be used | [optional] 
**PriorPasswordRememberCount** | **long** | The number of prior passwords for the user to be remembered by the vCenter appliance in order for the appliance to assess non-repetition.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60; then no warning will be provided. | [optional] 
**FailedAttemptCountBeforeAccountLockout** | **long** | Threshold Number of consecutive authentication failures for the user during the recent interval before the account is locked out.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60; then no warning will be provided | [optional] 
**LengthOfLockoutPeriodInSeconds** | **long** | The access will be reenabled after n seconds after the lock out.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60; then no warning will be provided | [optional] 
**FailIntervalBetweenAttempts** | **long** | The length of the interval during which the consecutive authentication failures must happen for the user account lock out  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60; then the restriction will be ignored. | [optional] 
**MinimumLength** | **long** | Minimum number of the characters needed in the password.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60; then the restriction will be ignored. | [optional] 
**MinimumUppercaseCharCount** | **long** | Minimum number of upper case characters needed in the password.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60; then the restriction will be ignored. | [optional] 
**MinimumLowercaseCharCount** | **long** | Minimum number of lower case characters needed in the password.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60; then the restriction will be ignored. | [optional] 
**MinimumNumericsCharCount** | **long** | Minimum number of numeric characters needed in the password.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60; then the restriction will be ignored. | [optional] 
**MinimumSpecialCharCount** | **long** | Minimum number of special characters needed in the password.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60; then the restriction will be ignored. | [optional] 
**ManagedAtFleet** | **bool** | Whether the password policy is managed at fleet or not.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60; then the password policy is not fleet managed | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

