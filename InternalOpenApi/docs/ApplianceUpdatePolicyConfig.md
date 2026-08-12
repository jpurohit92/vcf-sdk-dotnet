# Vcenter.Automation.OpenApi.Model.ApplianceUpdatePolicyConfig
The Appliance.Update.Policy.Config schema defines automatic update checking and staging policy.  This schema was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomUrl** | **string** | Current appliance update repository URL.  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60; then default URL is assumed | [optional] 
**Username** | **string** | Username for the update repository  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60; username will not be used to login | [optional] 
**Password** | **string** | Password for the update repository  This property was added in __vSphere API 6.7__.  password If missing or &#x60;null&#x60; password will not be used to login | [optional] 
**CheckSchedule** | [**List&lt;ApplianceUpdatePolicyTime&gt;**](ApplianceUpdatePolicyTime.md) | Schedule when the automatic check will be run.  This property was added in __vSphere API 6.7__. | 
**AutoStage** | **bool** | Automatically stage the latest update if available.  This property was added in __vSphere API 6.7__. | 
**CertificateCheck** | **bool** | Indicates whether certificates will be checked during patching.    Warning: Setting this property to false will result in an insecure connection to update repository which can potentially put the appliance security at risk.  This property was added in __vSphere API 6.7__.  certificateCheck If missing or &#x60;null&#x60; the certificate checks are enabled. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

