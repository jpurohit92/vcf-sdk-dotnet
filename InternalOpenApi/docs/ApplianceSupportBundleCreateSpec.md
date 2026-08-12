# Vcenter.Automation.OpenApi.Model.ApplianceSupportBundleCreateSpec
This schema was added in __vSphere API 7.0.1.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** | Support bundle creation description.  This property was added in __vSphere API 7.0.1.0__. | 
**Components** | **Dictionary&lt;string, List&lt;string&gt;&gt;** | Support bundle components to be included. Map with groupName as key and list of components in that group as the value.  This property was added in __vSphere API 7.0.1.0__. | [optional] 
**ContentType** | **string** | Describes the content type to be collected in support bundle.  Possible values:   - &#x60;LOGS&#x60;: Support bundle will contain only logs.   - &#x60;CORES&#x60;: Support bundle will contain only core files.   - &#x60;ALL&#x60;: Support bundle will contain logs and core files. By default logs and cores are collected.   For more information see: *Appliance.SupportBundle.ContentType*.  This property was added in __vSphere API 8.0.2.0__.  If missing or &#x60;null&#x60;, both logs and core files will be collected. | [optional] 
**Partition** | **string** | Partition to be used for saving the support bundle. Available partitions can be retrieved using storage.list API.  This property was added in __vSphere API 7.0.1.0__. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

