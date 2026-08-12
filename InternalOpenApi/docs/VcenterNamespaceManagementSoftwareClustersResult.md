# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSoftwareClustersResult
This schema is deprecated as of __vSphere API 9.1.0.0__.  The Vcenter.NamespaceManagement.Software.Clusters.Result schema contains the result of batch upgrade method.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Res** | **string** | This property is deprecated as of __vSphere API 9.1.0.0__.  The result of batch upgrade method.  Possible values:   - &#x60;STARTED&#x60;: Upgrade is started.   - &#x60;REJECTED&#x60;: Upgrade is rejected. This implies pre-check failed when invoking upgrade of the cluster.   For more information see: *Vcenter.NamespaceManagement.Software.Clusters.Result.Res*.  This property was added in __vSphere API 7.0.0.0__. | 
**Exception** | **Object** | This property is deprecated as of __vSphere API 9.1.0.0__.  Exception when cluster pre-check failed during upgrade invocation.  This property was added in __vSphere API 7.0.0.0__.  This property is optional and it is only relevant when the value of res is *Vcenter.NamespaceManagement.Software.Clusters.Result.Res.REJECTED*. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

