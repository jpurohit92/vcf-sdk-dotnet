# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersConfigurationReferenceHostInfo
The Esx.Settings.Clusters.Configuration.ReferenceHostInfo schema contains properties that describe the host that was used as a reference for generating the schema.  This schema was added in __vSphere API 8.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | The current status of the reference host.  Possible values:   - &#x60;OK&#x60;: The reference host is in the cluster and connected.   - &#x60;DISCONNECTED&#x60;: The reference host is in the cluster, but disconnected.   - &#x60;UNAVAILABLE&#x60;: There is no reference host or it is no longer in the cluster.   For more information see: *Esx.Settings.Clusters.Configuration.ReferenceHostInfo.Status*.  This property was added in __vSphere API 8.0.3.0__. | 
**Host** | **string** | The ID of the reference host.  This property was added in __vSphere API 8.0.3.0__.  This property is optional and it is only relevant when the value of status is one of *Esx.Settings.Clusters.Configuration.ReferenceHostInfo.Status.OK* or *Esx.Settings.Clusters.Configuration.ReferenceHostInfo.Status.DISCONNECTED*.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;HostSystem&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;HostSystem&#x60;. | [optional] 
**Name** | **string** | The name of the reference host.  This property was added in __vSphere API 8.0.3.0__.  This property is optional and it is only relevant when the value of status is one of *Esx.Settings.Clusters.Configuration.ReferenceHostInfo.Status.OK* or *Esx.Settings.Clusters.Configuration.ReferenceHostInfo.Status.DISCONNECTED*. | [optional] 
**Summary** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | A summary of the reference host status.  This property was added in __vSphere API 8.0.3.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

