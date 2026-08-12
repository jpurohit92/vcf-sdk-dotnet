# Vcenter.Automation.OpenApi.Model.VcenterNamespacesInstancesStorageSpec
The Vcenter.Namespaces.Instances.StorageSpec schema contains the specification required to configure storage associated with a namespace. Information in this schema will result in storage quotas on the Kubernetes namespace.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Policy** | **string** | ID of the storage policy. A Kubernetes storage class is created for this storage policy if it does not exist already.  This property was added in __vSphere API 7.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;SpsStorageProfile&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;SpsStorageProfile&#x60;. | 
**Limit** | **long** | The maximum amount of storage (in mebibytes) which can be utilized by the namespace for this specification.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, no limits are placed. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

