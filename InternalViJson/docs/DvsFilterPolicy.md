# Vcenter.ViJson.OpenApi.Model.DvsFilterPolicy

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Inherited** | **bool** | Whether the configuration is set to inherited value.  | 
**FilterConfig** | [**List&lt;DvsFilterConfig&gt;**](DvsFilterConfig.md) | List of Network Filter Configurations.  In an update operation, the array can contain all *DvsTrafficFilterConfigSpec* objects or all *DvsFilterConfig* and *DvsTrafficFilterConfig* object, but not mixed of Config and Spec objects. If array of *DvsFilterConfigSpec* and *DvsTrafficFilterConfigSpec* is used for updating Network Filter then only the Network Filters matching *DistributedVirtualPort.key* / *DistributedVirtualPort.key* is updated. If array of *DvsFilterConfig* and *DvsTrafficFilterConfig* is used for updating port settings, the Network Filter settings will be overridden with the new array specified. The specified array should only contain *DvsFilterConfig* and *DvsTrafficFilterConfig* objects with *InheritablePolicy.inherited* / *InheritablePolicy.inherited* set to false. *DvsFilterConfig*_/_*DvsTrafficFilterConfig* objects with *InheritablePolicy.inherited*_/_*InheritablePolicy.inherited* as true in the specified array will be ignored. The updated result will include *DvsFilterConfig*_/_*DvsTrafficFilterConfig* objects inherited from parent, if any.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

