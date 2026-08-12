# Vcenter.Automation.OpenApi.Model.VcenterCapacityUsageInfo
The Vcenter.Capacity.Usage.Info schema contains information about the current configuration usage and its compliance with the configuration recommendation by Broadcom. Additionally, it provides an URI where the CSV report can be downloaded from.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreatedAt** | **DateTime** | The timestamp when the result was generated.  This property was added in __vSphere API 9.1.0.0__. | 
**DeploymentSize** | **string** | The current deployment size of the vCenter server (for example: tiny,small,medium,large,x-large).  This property was added in __vSphere API 9.1.0.0__. | 
**VarVersion** | **string** | The current vCenter server version.  This property was added in __vSphere API 9.1.0.0__. | 
**CreatedBy** | **string** | The user who initiated the request.  This property was added in __vSphere API 9.1.0.0__. | 
**Configurations** | [**List&lt;VcenterCapacityUsageConfig&gt;**](VcenterCapacityUsageConfig.md) | List of configuration objects containing the current usage and Broadcom&#39;s recommendation.  This property was added in __vSphere API 9.1.0.0__. | 
**CsvReportLocation** | [**VcenterCapacityUsageCsvReportLocation**](VcenterCapacityUsageCsvReportLocation.md) | Contains the URI to access the CSV Report and the authentication token required to access it.  This property was added in __vSphere API 9.1.0.0__.  missing or &#x60;null&#x60; in case of any *Vcenter.Capacity.Usage.Info.error* reported. | [optional] 
**Error** | [**VapiStdErrorsError**](VapiStdErrorsError.md) | Contains error message generated during the validation.  This property was added in __vSphere API 9.1.0.0__.  set if any errors encountered before calling the downstream APIs or when *Vcenter.Capacity.Usage.Config.error* is set or any errors reported during CSV generation. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

