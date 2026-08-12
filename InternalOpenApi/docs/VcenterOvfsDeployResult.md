# Vcenter.Automation.OpenApi.Model.VcenterOvfsDeployResult
The Vcenter.Ovfs.DeployResult schema defines the result of a successful API call which will include the ID of the entity created.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ResultType** | **string** | Type for the result.  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be one of &#x60;VirtualApp&#x60; or &#x60;VirtualMachine&#x60;. When operations return a value of this schema as a response, the property will be one of &#x60;VirtualApp&#x60; or &#x60;VirtualMachine&#x60;. | 
**CreatedEntity** | **string** | Identifier of the deployed Virtual Machine or Virtual Appliance if deployment succeeded. In case of a deployment failure an exception is thrown instead of returning DeployResult.  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for one of these resource types: &#x60;VirtualApp&#x60; or &#x60;VirtualMachine&#x60;. When operations return a value of this schema as a response, the property will be an identifier for one of these resource types: &#x60;VirtualApp&#x60; or &#x60;VirtualMachine&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

