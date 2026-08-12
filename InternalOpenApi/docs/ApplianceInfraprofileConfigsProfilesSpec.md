# Vcenter.Automation.OpenApi.Model.ApplianceInfraprofileConfigsProfilesSpec
This schema is deprecated as of __vSphere API 9.0.0.0__.  The Appliance.Infraprofile.Configs.ProfilesSpec schema represents a spec information for export operation.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EncryptionKey** | **string** | This property is deprecated as of __vSphere API 9.0.0.0__.  Encryption Key to encrypt/decrypt profiles.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60; encryption will not be used for the profile. | [optional] 
**Description** | **string** | This property is deprecated as of __vSphere API 9.0.0.0__.  Custom description provided by the user.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60; description will be empty. | [optional] 
**Profiles** | **List&lt;string&gt;** | This property is deprecated as of __vSphere API 9.0.0.0__.  Profiles to be exported/imported.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60; or empty, all profiles will be returned.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;com.vmware.infraprofile.profile&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;com.vmware.infraprofile.profile&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

