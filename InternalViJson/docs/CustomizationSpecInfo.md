# Vcenter.ViJson.OpenApi.Model.CustomizationSpecInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Unique name of the specification.  | 
**Description** | **string** | Description of the specification.  | 
**Type** | **string** | Guest operating system for this specification (Linux or Windows).  | 
**ChangeVersion** | **string** | The changeVersion is a unique identifier for a given version of the configuration.  Each change to the configuration will update this value. This is typically implemented as an ever increasing count or a time-stamp. However, a client should always treat this as an opaque string.  If specified when updating a specification, the changes will only be applied if the current changeVersion matches the specified changeVersion. This field can be used to guard against updates that has happened between the configInfo was read and until it is applied.  | [optional] 
**LastUpdateTime** | **DateTime** | Time when the specification was last modified.  This time is ignored when the CustomizationSpecItem containing this is used as an input to CustomizationSpecManager.create.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

