# Vcenter.ViJson.OpenApi.Model.GenerateLogBundlesRequestType
The parameters of *DiagnosticManager.GenerateLogBundles_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IncludeDefault** | **bool** | Specifies if the bundle should include the default server. If called on a VirtualCenter server, then this means the VirtualCenter diagnostic files. If called directly on a host, then includeDefault must be set to true.  | 
**Host** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | Lists hosts that are included. This is only used when called on VirtualCenter. If called directly on a host, then this parameter must be empty.  Refers instances of *HostSystem*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

