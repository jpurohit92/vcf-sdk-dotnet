# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementStatsTimeSeriesSpec
This structure is sent in a request for TimeSeries data and is used to specify what object stats should be returned for.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ObjType** | **string** | Type of statistics object that the request is operating on.  Possible values:   - &#x60;CLUSTER&#x60;: The CLUSTER object type is used when specifying a vSphere cluster.   - &#x60;NAMESPACE&#x60;: The NAMESPACE object type is used to specify a namespace.   - &#x60;POD&#x60;: The POD object type is used to specify an individual pod within a namespace.   For more information see: *Vcenter.NamespaceManagement.Stats.TimeSeries.Spec.ObjType*.  This property was added in __vSphere API 7.0.0.0__. | 
**Namespace** | **string** | Namespace name for queries for a namespace.  This property was added in __vSphere API 7.0.0.0__.  This property is optional and it is only relevant when the value of obj_type is *Vcenter.NamespaceManagement.Stats.TimeSeries.Spec.ObjType.NAMESPACE*.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.namespaces.Instance&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.namespaces.Instance&#x60;. | [optional] 
**Cluster** | **string** | Cluster identifier for queries for a cluster.  This property was added in __vSphere API 7.0.0.0__.  This property is optional and it is only relevant when the value of obj_type is *Vcenter.NamespaceManagement.Stats.TimeSeries.Spec.ObjType.CLUSTER*.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;ClusterComputeResource&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;ClusterComputeResource&#x60;. | [optional] 
**Start** | **long** | UNIX timestamp value indicating when the requested series of statistical samples should begin. https://en.wikipedia.org/wiki/Unix_time  This property was added in __vSphere API 7.0.0.0__. | 
**End** | **long** | UNIX timestamp value indicating when the requested series of statistical samples should end. https://en.wikipedia.org/wiki/Unix_time  This property was added in __vSphere API 7.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

