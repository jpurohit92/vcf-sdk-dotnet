# Vcenter.ViJson.OpenApi.Model.VsanHostHealthSystemVersionResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Hostname** | **string** | The name of the host  | 
**VarVersion** | **string** | Version number string of vSAN health service of host.  If vSAN health service is not installed on this host, the version value returned will be &#39;0.0&#39;, and an error message will be set in error field of this model. The field will be unset if the query fails except the case that the service is not install on this host.  | [optional] 
**Error** | [**MethodFault**](MethodFault.md) | This field will be set only when the query fails, it stores the error message for querying vSAN health service version to a host.  | [optional] 
**Build** | **string** | The build number of the ESXi host.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

