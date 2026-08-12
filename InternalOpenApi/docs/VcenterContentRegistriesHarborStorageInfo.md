# Vcenter.Automation.OpenApi.Model.VcenterContentRegistriesHarborStorageInfo
This schema is deprecated as of __vSphere API 8.0.1.00200__.  The Vcenter.Content.Registries.Harbor.StorageInfo schema contains the detailed information about storage used by the Harbor registry.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Policy** | **string** | This property is deprecated as of __vSphere API 8.0.1.00200__.  Identifier of the storage policy.  This property was added in __vSphere API 7.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;SpsStorageProfile&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;SpsStorageProfile&#x60;. | 
**Capacity** | **long** | This property is deprecated as of __vSphere API 8.0.1.00200__.  Total capacity for the registry storage (in mebibytes). This is the storage limit set on the Harbor registry. If a storage limit was not set on the registry, the default registry capacity - 204800 mebibytes is used.  This property was added in __vSphere API 7.0.0.0__. | 
**Used** | **long** | This property is deprecated as of __vSphere API 8.0.1.00200__.  Overall storage used by the registry (in mebibytes). This is the sum of used storage associated with storage policies configured for the registry.  This property was added in __vSphere API 7.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

