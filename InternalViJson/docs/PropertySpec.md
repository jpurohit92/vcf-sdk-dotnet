# Vcenter.ViJson.OpenApi.Model.PropertySpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Name of the managed object type being collected.  | 
**All** | **bool** | Specifies whether or not all properties of the object are read.  If this property is set to true, the *PropertySpec.pathSet* property is ignored.  | [optional] 
**PathSet** | **List&lt;string&gt;** | Specifies which managed object properties are retrieved.  If the *PropertySpec.pathSet* is empty, then the *PropertyCollector* retrieves references to the managed objects and no managed object properties are collected.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

