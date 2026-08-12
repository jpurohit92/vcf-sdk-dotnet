# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersConfigurationDraftsChangedProperty
The Esx.Settings.Clusters.Configuration.Drafts.ChangedProperty schema contains information about a property that is different in this draft from the committed configuration.  This schema was added in __vSphere API 8.0.2.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Path** | **string** | A JSON-Pointer that refers to the property that has been changed.  This property was added in __vSphere API 8.0.2.0__. | 
**DisplayPath** | **List&lt;string&gt;** | A list of the display names for components of *Esx.Settings.Clusters.Configuration.Drafts.ChangedProperty.path* property.  This property was added in __vSphere API 9.1.0.0__.  This field is missing or &#x60;null&#x60; if the display names cannot be computed. | [optional] 
**Type** | **string** | The data type of the property pointed by {#path}.  Possible values:   - &#x60;PRIMITIVE&#x60;: The changed property is of primitive data type.   - &#x60;OBJECT&#x60;: The changed property is of type object.   - &#x60;ARRAY_OF_OBJECTS&#x60;: The changed property is of array of object data type.   - &#x60;ARRAY_OF_PRIMITIVES&#x60;: The changed property is of array of primitive data type.   For more information see: *Esx.Settings.Clusters.Configuration.Drafts.ChangedProperty.Type*.  This property was added in __vSphere API 9.1.0.0__.  This field is missing or &#x60;null&#x60; if the data type of the property is not available. | [optional] 
**Current** | **string** | This property was added in __vSphere API 8.0.2.0__.  If set, the current value of the property in the cluster configuration. If not set, the property does not exist in the current cluster configuration. | [optional] 
**Draft** | **string** | This property was added in __vSphere API 8.0.2.0__.  If set, this is the new value for the property in this draft. If not set, the property has been deleted in this draft. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

