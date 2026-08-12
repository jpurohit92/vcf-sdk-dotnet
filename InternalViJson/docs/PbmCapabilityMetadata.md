# Vcenter.ViJson.OpenApi.Model.PbmCapabilityMetadata

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**PbmCapabilityMetadataUniqueId**](PbmCapabilityMetadataUniqueId.md) | Unique identifier for the capability.  | 
**Summary** | [**PbmExtendedElementDescription**](PbmExtendedElementDescription.md) | Capability name and description  | 
**Mandatory** | **bool** | Indicates whether incorporating given capability is mandatory during creation of profile.  | [optional] 
**Hint** | **bool** | The flag hint dictates the interpretation of constraints specified for this capability in a storage policy profile.  If hint is false, then constraints will affect placement. If hint is true, constraints will not affect placement, but will still be passed to provisioning operations if the provider understands the relevant namespace. Optional property, false if not set.  | [optional] 
**KeyId** | **string** | Property Id of the key property, if this capability represents a key value pair.  Value is empty string if not set.  | [optional] 
**AllowMultipleConstraints** | **bool** | Flag to indicate if multiple constraints are allowed in the capability instance.  False if not set.  | [optional] 
**PropertyMetadata** | [**List&lt;PbmCapabilityPropertyMetadata&gt;**](PbmCapabilityPropertyMetadata.md) | Metadata for the properties that comprise this capability.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

