# Vcenter.ViJson.OpenApi.Model.HostProfileCompleteConfigSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApplyProfile** | [**HostApplyProfile**](HostApplyProfile.md) | Profile that contains configuration data for the host.  | [optional] 
**CustomComplyProfile** | [**ComplianceProfile**](ComplianceProfile.md) | User defined compliance profile.  Reserved for future use.  | [optional] 
**DisabledExpressionListChanged** | **bool** | Flag indicating if this configuration specification contains changes in the *HostProfileCompleteConfigSpec.disabledExpressionList*.  If False, the Profile Engine ignores the contents of the disabled expression list.  | 
**DisabledExpressionList** | **List&lt;string&gt;** | List of expressions to be disabled.  Each entry in the list specifies a *ProfileExpression*.*ProfileExpression.id*. All expressions are enabled by default.  If you set *HostProfileCompleteConfigSpec.disabledExpressionListChanged* to True, the Profile Engine uses the contents of this list to replace the contents of the *HostProfile*.*Profile.config*.*HostProfileConfigInfo.disabledExpressionList*.  The expression list is contained in the *HostProfileConfigInfo.defaultComplyProfile*. The Profile Engine automatically generates the default compliance profile when you create a host profile.  | [optional] 
**ValidatorHost** | [**ManagedObjectReference**](ManagedObjectReference.md) | Host for profile validation.  This can be a host on which the profile is intended to be used. If you do not specify a validator host, the Profile Engine uses the *HostProfile*.*HostProfile.referenceHost* to validate the profile.  Refers instance of *HostSystem*.  | [optional] 
**Validating** | **bool** | If \&quot;false\&quot;, then the host profile will be saved without being validated.  The default if not specified is \&quot;true\&quot;. This option should be used with caution, since the resulting host profile will not be checked for errors.  | [optional] 
**HostConfig** | [**HostProfileConfigInfo**](HostProfileConfigInfo.md) | Host profile configuration data and compliance information.  If *HostProfileCompleteConfigSpec.hostConfig* is set, then the HostApplyProfile *HostProfileCompleteConfigSpec.applyProfile* and ComplianceProfile *HostProfileCompleteConfigSpec.customComplyProfile* should not be set in CompleteConfigSpec.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

