# Vcenter.Automation.OpenApi.Model.VcenterContentRegistriesHarborInfo
This schema is deprecated as of __vSphere API 8.0.1.00200__.  The Vcenter.Content.Registries.Harbor.Info schema contains detailed information about a running Harbor registry.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | **string** | This property is deprecated as of __vSphere API 8.0.1.00200__.  Identifier of the cluster.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, container registry is not created on the cluster specified by *Vcenter.Content.Registries.Harbor.CreateSpec.cluster*.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;ClusterComputeResource&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;ClusterComputeResource&#x60;. | [optional] 
**Namespace** | **string** | This property is deprecated as of __vSphere API 8.0.1.00200__.  Identifier of the Harbor namespace in case it is created in a Kubernetes environment.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, no Kubernetes namespace is created for the Harbor.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;NamespaceInstance&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;NamespaceInstance&#x60;. | [optional] 
**VarVersion** | **string** | This property is deprecated as of __vSphere API 8.0.1.00200__.  Version of the registry.  This property was added in __vSphere API 7.0.0.0__. | 
**CreationTime** | **DateTime** | This property is deprecated as of __vSphere API 8.0.1.00200__.  The date and time when the harbor registry was created.  This property was added in __vSphere API 7.0.0.0__. | 
**UiAccessUrl** | **string** | This property is deprecated as of __vSphere API 8.0.1.00200__.  URL to access the UI of the registry.  This property was added in __vSphere API 7.0.0.0__. | 
**CertChain** | **List&lt;string&gt;** | This property is deprecated as of __vSphere API 8.0.1.00200__.  Harbor certificate chain in base64 format.  This property was added in __vSphere API 7.0.0.0__. | 
**GarbageCollection** | [**VcenterContentRegistriesHarborGarbageCollection**](VcenterContentRegistriesHarborGarbageCollection.md) | This property is deprecated as of __vSphere API 8.0.1.00200__.  Garbage collection information for the registry.  This property was added in __vSphere API 7.0.0.0__. | 
**Storage** | [**List&lt;VcenterContentRegistriesHarborStorageInfo&gt;**](VcenterContentRegistriesHarborStorageInfo.md) | This property is deprecated as of __vSphere API 8.0.1.00200__.  Storage information associated with the registry.  This property was added in __vSphere API 7.0.0.0__. | 
**Health** | [**VcenterContentRegistriesHealthInfo**](VcenterContentRegistriesHealthInfo.md) | This property is deprecated as of __vSphere API 8.0.1.00200__.  Health status of the container registry.  This property was added in __vSphere API 7.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

