# Vcenter.ViJson.OpenApi.Model.InstallIoFilterRequestType
The parameters of *IoFilterManager.InstallIoFilter_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VibUrl** | **string** | The URL that points to the IO Filter VIB package.  | 
**CompRes** | [**ManagedObjectReference**](ManagedObjectReference.md) | The compute resource to install the IO Filter on. \&quot;compRes\&quot; must be a cluster.  Refers instance of *ComputeResource*.  | 
**VibSslTrust** | [**IoFilterManagerSslTrust**](IoFilterManagerSslTrust.md) | This specifies SSL trust policy *IoFilterManagerSslTrust* for the given VIB URL. If unset, the server certificate is validated against the trusted root certificates.  ***Since:*** vSphere API Release 8.0.3.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

