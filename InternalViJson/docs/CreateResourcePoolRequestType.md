# Vcenter.ViJson.OpenApi.Model.CreateResourcePoolRequestType
The parameters of *ResourcePool.CreateResourcePool*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the ResourcePool. Any % (percent) character used in this parameter must be escaped, unless it is used to start an escape sequence. Clients may also escape any other characters in this parameter.  | 
**Spec** | [**ResourceConfigSpec**](ResourceConfigSpec.md) | The spec for the ResourcePool. All values in ResourceAllocationInfo must be specified and are not optional.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

