# Vcenter.Automation.OpenApi.Model.VcenterCapacityUsageConfig
The Vcenter.Capacity.Usage.Config schema contains the validation results for a specific configuration including the current usage, Broadcom's recommendation, and information if the current usage is compliant with the set thresholds.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier of the configuration.  This property was added in __vSphere API 9.1.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.capacity.usage&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.capacity.usage&#x60;. | 
**Name** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | Name of the configuration.  This property was added in __vSphere API 9.1.0.0__. | 
**ThresholdPercentage** | **double** | Threshold percentage set for the configuration, ranging from 1 to 100 (inclusive).  This property was added in __vSphere API 9.1.0.0__. | 
**MaxRecommendedValue** | **double** | Maximum recommended value of the configuration.  This property was added in __vSphere API 9.1.0.0__. | 
**CurrentUsageValue** | **double** | The current usage/count of the configuration.  This property was added in __vSphere API 9.1.0.0__.  missing or &#x60;null&#x60; if there is an error fetching the value. | [optional] 
**CurrentUsagePercentage** | **double** | The percentage of the configuration&#39;s maximum that is currently used. Calculated as (*Vcenter.Capacity.Usage.Config.current_usage_value*_/_*Vcenter.Capacity.Usage.Config.max_recommended_value*)*100  This property was added in __vSphere API 9.1.0.0__.  missing or &#x60;null&#x60; if there is an error fetching the *Vcenter.Capacity.Usage.Config.current_usage_value*. | [optional] 
**CapacityUnit** | **string** | The capacity unit of measurement for the *Vcenter.Capacity.Usage.Config.max_recommended_value* and *Vcenter.Capacity.Usage.Config.current_usage_value* (for example: \&quot;TB\&quot;, \&quot;GB\&quot;, \&quot;ms\&quot;, ..).  This property was added in __vSphere API 9.1.0.0__.  missing or &#x60;null&#x60; if the values are plain integers without a capacity unit. | [optional] 
**Severity** | **string** | Indicates the severity of the configuration&#39;s usage.  Possible values:   - &#x60;NORMAL&#x60;: The configuration&#39;s current usage is within the defined threshold.   - &#x60;THRESHOLD_EXCEEDED&#x60;: The configuration&#39;s current usage has exceeded the defined threshold.   - &#x60;MAXIMUM_EXCEEDED&#x60;: The configuration&#39;s current usage has exceeded the maximum recommended value.   For more information see: *Vcenter.Capacity.Usage.Severity*.  This property was added in __vSphere API 9.1.0.0__.  missing or &#x60;null&#x60; if there is an error fetching the *Vcenter.Capacity.Usage.Config.current_usage_value*. | [optional] 
**Error** | [**VapiStdErrorsError**](VapiStdErrorsError.md) | Contains the error message if an error occurs while fetching the configuration&#39;s data.  This property was added in __vSphere API 9.1.0.0__.  set if any issues encountered. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

