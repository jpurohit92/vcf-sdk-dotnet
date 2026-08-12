# Vcenter.Automation.OpenApi.Model.ApplianceSupportBundleInfo
This schema was added in __vSphere API 7.0.1.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** | Support bundle creation description.  This property was added in __vSphere API 7.0.1.0__. | 
**Status** | **string** | Status of the task  Possible values:   - &#x60;SUCCEEDED&#x60;: Support bundle creation task succeeded.   - &#x60;FAILED&#x60;: Support bundle creation task Failed.   - &#x60;CANCELLED&#x60;: Support bundle creation task Cancelled.   For more information see: *Appliance.SupportBundle.CreationStatus*.  This property was added in __vSphere API 7.0.1.0__. | 
**GenerationTime** | **DateTime** | Support bundle generation time.  This property was added in __vSphere API 7.0.1.0__.  This property is optional and it is only relevant when the value of status is *Appliance.SupportBundle.CreationStatus.SUCCEEDED*. | [optional] 
**Url** | **string** | Support bundle downlooad URL.  This property was added in __vSphere API 7.0.1.0__.  This property is optional and it is only relevant when the value of status is *Appliance.SupportBundle.CreationStatus.SUCCEEDED*. | [optional] 
**ExpirationTime** | **DateTime** | Download expiration time.  This property was added in __vSphere API 7.0.1.0__.  This property is optional and it is only relevant when the value of status is *Appliance.SupportBundle.CreationStatus.SUCCEEDED*. | [optional] 
**Downloadable** | **bool** | Support bundle availability for download.  This property was added in __vSphere API 7.0.1.0__.  This property is optional and it is only relevant when the value of status is *Appliance.SupportBundle.CreationStatus.SUCCEEDED*. | [optional] 
**Size** | **long** | Support bundle file size in KBs.  This property was added in __vSphere API 7.0.1.0__.  This property is optional and it is only relevant when the value of status is *Appliance.SupportBundle.CreationStatus.SUCCEEDED*. | [optional] 
**FailureReason** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | Reason for failure  This property was added in __vSphere API 7.0.1.0__.  This property is optional and it is only relevant when the value of status is *Appliance.SupportBundle.CreationStatus.FAILED*. | [optional] 
**ChecksumValue** | **string** | Support bundle SHA256 checksum value.  This property was added in __vSphere API 8.0.2.0__.  This property is optional and it is only relevant when the value of status is *Appliance.SupportBundle.CreationStatus.SUCCEEDED*. | [optional] 
**Id** | **string** | Identifier of the support bundle.  This property was added in __vSphere API 8.0.2.0__.  This property is optional because it was added in a newer version than its parent node.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.appliance.supportbundle&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.appliance.supportbundle&#x60;. | [optional] 
**ContentType** | **string** | Describes the content type (ContentType) collected in support bundle.  Possible values:   - &#x60;LOGS&#x60;: Support bundle will contain only logs.   - &#x60;CORES&#x60;: Support bundle will contain only core files.   - &#x60;ALL&#x60;: Support bundle will contain logs and core files. By default logs and cores are collected.   For more information see: *Appliance.SupportBundle.ContentType*.  This property was added in __vSphere API 8.0.2.0__.  This property is optional and it is only relevant when the value of status is *Appliance.SupportBundle.CreationStatus.SUCCEEDED*. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

