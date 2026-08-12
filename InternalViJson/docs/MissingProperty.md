# Vcenter.ViJson.OpenApi.Model.MissingProperty

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Path** | **string** | Property for which a value could not be retrieved  | 
**Fault** | [**MethodFault**](MethodFault.md) | Fault describing the failure to retrieve the property value.  The possible faults for missing properties are: - *SystemError* if there was some unknown problem   reading the value - *SecurityError* if the logged in session did   not have permission to read the value  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

