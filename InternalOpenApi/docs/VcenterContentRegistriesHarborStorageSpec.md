# Vcenter.Automation.OpenApi.Model.VcenterContentRegistriesHarborStorageSpec
This schema is deprecated as of __vSphere API 8.0.1.00200__.  The Vcenter.Content.Registries.Harbor.StorageSpec schema contains the specification required to configure storage associated with a Harbor registry. In this version, Harbor registry is created in Kubernetes environment, information in this schema will result in storage quotas on a Kubernetes namespace.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Policy** | **string** | This property is deprecated as of __vSphere API 8.0.1.00200__.  Identifier of the storage policy.  This property was added in __vSphere API 7.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;SpsStorageProfile&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;SpsStorageProfile&#x60;. | 
**Limit** | **long** | This property is deprecated as of __vSphere API 8.0.1.00200__.  The maximum amount of storage (in mebibytes) which can be utilized by the registry for this specification.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, a default limit of 204800 mebibytes will be set as the registry&#39;s storage capacity. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

