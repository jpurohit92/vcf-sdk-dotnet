# Vcenter.Automation.OpenApi.Model.VcenterClusterEvcModeCheckResult
Information returned from operations that check EvcMode based compatibility.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Error** | [**VapiStdErrorsError**](VapiStdErrorsError.md) | The error associated with the check.  This property was added in __vSphere API 9.0.0.0__. | 
**HostSystem** | **string** | The host associated with the error.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, then the error is not associated with any host.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;HostSystem&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;HostSystem&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

