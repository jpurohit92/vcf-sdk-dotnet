# Vcenter.ViJson.OpenApi.Model.PbmCapabilityPropertyInstance

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Requirement property identifier.  This identifier corresponds to the storage capability metadata identifier (*PbmCapabilityPropertyMetadata*.*PbmCapabilityPropertyMetadata.id*).  | 
**Operator** | **string** | Operator for the values.  Currently only support NOT operator for tag namespace See operator definition in (*PbmCapabilityOperator_enum*).  | [optional] 
**Value** | [**Any**](Any.md) | Property value.  You must specify the value. A property value is one value or a collection of values. - A single property value is expressed as a scalar value. - A collection of values is expressed as a *PbmCapabilityDiscreteSet*   or a *PbmCapabilityRange* of values.    The datatype of each value must be one of the *PbmBuiltinType_enum* datatypes. If the property consists of a collection of values, the interpretation of those values is determined by the *PbmCapabilityGenericTypeInfo*.  Type information for a property instance is described in the property metadata (*PbmCapabilityPropertyMetadata*.*PbmCapabilityPropertyMetadata.type*).  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

