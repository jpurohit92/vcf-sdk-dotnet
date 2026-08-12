# Vcenter.Automation.OpenApi.Model.ApplianceUpdatePolicyInfo
The Appliance.Update.Policy.Info schema defines automatic update checking and staging policy.  This schema was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomUrl** | **string** | Current appliance update custom repository URL.  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60; update is checked at defaut URL. | [optional] 
**DefaultUrl** | **string** | Current appliance update default repository URL.  This property was added in __vSphere API 6.7__. | 
**Username** | **string** | Username for the update repository  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60; username will not be used to login | [optional] 
**CheckSchedule** | [**List&lt;ApplianceUpdatePolicyTime&gt;**](ApplianceUpdatePolicyTime.md) | Schedule when the automatic check will be run.  This property was added in __vSphere API 6.7__. | 
**AutoStage** | **bool** | Automatically stage the latest update if available.  This property was added in __vSphere API 6.7__. | 
**AutoUpdate** | **bool** | Is the appliance updated automatically. If set the appliance may ignore the check schedule or auto-stage settings.  This property was added in __vSphere API 6.7__. | 
**ManualControl** | **bool** | Whether API client should allow the user to start update manually  This property was added in __vSphere API 6.7__. | 
**CertificateCheck** | **bool** | Indicates whether certificates will be checked during patching.    Warning: If this property is set to false, an insecure connection is made to the update repository which can potentially put the appliance security at risk.  This property was added in __vSphere API 6.7__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

