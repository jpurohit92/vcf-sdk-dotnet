# Vcenter.ViJson.OpenApi.Model.UpgradeIoFilterRequestType
The parameters of *IoFilterManager.UpgradeIoFilter_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FilterId** | **string** | The filter to be upgraded.  | 
**CompRes** | [**ManagedObjectReference**](ManagedObjectReference.md) | The compute resource that the filter is installed on. \&quot;compRes\&quot; must be a cluster.  Refers instance of *ComputeResource*.  | 
**VibUrl** | **string** | The URL that points to the new IO Filter VIB package.  | 
**VibSslTrust** | [**IoFilterManagerSslTrust**](IoFilterManagerSslTrust.md) | This specifies SSL trust policy *IoFilterManagerSslTrust* for the given VIB URL. If unset, the server certificate is validated against the trusted root certificates.  ***Since:*** vSphere API Release 8.0.3.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

