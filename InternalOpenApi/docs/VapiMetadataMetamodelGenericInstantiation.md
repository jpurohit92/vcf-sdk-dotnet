# Vcenter.Automation.OpenApi.Model.VapiMetadataMetamodelGenericInstantiation
The Vapi.Metadata.Metamodel.GenericInstantiation schema describes the type information of a typed element when the type is an instantiation of one of the generic types provided by the infrastructure.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GenericType** | **string** | The generic type that is being instantiated.  Possible values:   - &#x60;LIST&#x60;: Indicates the generic type is a list.   - &#x60;MAP&#x60;: Indicates the generic type is a map.   - &#x60;OPTIONAL&#x60;: Indicates the generic type is an optional.   - &#x60;SET&#x60;: Indicates the generic type is a set.   For more information see: *Vapi.Metadata.Metamodel.GenericInstantiation.GenericType*. | 
**ElementType** | [**VapiMetadataMetamodelType**](VapiMetadataMetamodelType.md) | Type of the element parameter if the generic type instantiation is a *Vapi.Metadata.Metamodel.GenericInstantiation.GenericType.LIST*, *Vapi.Metadata.Metamodel.GenericInstantiation.GenericType.OPTIONAL* or *Vapi.Metadata.Metamodel.GenericInstantiation.GenericType.SET*.  This property is optional and it is only relevant when the value of generic_type is one of *Vapi.Metadata.Metamodel.GenericInstantiation.GenericType.LIST*, *Vapi.Metadata.Metamodel.GenericInstantiation.GenericType.OPTIONAL*, or *Vapi.Metadata.Metamodel.GenericInstantiation.GenericType.SET*. | [optional] 
**MapKeyType** | [**VapiMetadataMetamodelType**](VapiMetadataMetamodelType.md) | Type of the key parameter of the map generic type instantiation. The map generic type has a key parameter and value parameter. The type of the value parameter is described by *Vapi.Metadata.Metamodel.GenericInstantiation.map_value_type*..  This property is optional and it is only relevant when the value of generic_type is *Vapi.Metadata.Metamodel.GenericInstantiation.GenericType.MAP*. | [optional] 
**MapValueType** | [**VapiMetadataMetamodelType**](VapiMetadataMetamodelType.md) | Type of the value parameter of the map generic type instantiation. The map generic type has a key parameter and value parameter. The type of the key parameter is described by *Vapi.Metadata.Metamodel.GenericInstantiation.map_key_type*..  This property is optional and it is only relevant when the value of generic_type is *Vapi.Metadata.Metamodel.GenericInstantiation.GenericType.MAP*. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

