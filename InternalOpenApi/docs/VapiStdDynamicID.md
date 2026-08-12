# Vcenter.Automation.OpenApi.Model.VapiStdDynamicID
The Vapi.Std.DynamicID schema represents an identifier for a resource of an arbitrary type.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of resource being identified (for example &#x60;com.acme.Person&#x60;).    Resources that contain operations for creating and deleting resources typically contain a constant specifying the resource type for the resources being created and deleted. The API metamodel metadata resources include a resource that allows retrieving all the known resource types. | 
**Id** | **string** | The identifier for a resource whose type is specified by *Vapi.Std.DynamicID.type*.  When clients pass a value of this schema as a parameter, the property type must contain the actual resource type. When operations return a value of this schema as a response, the property type will contain the actual resource type. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

