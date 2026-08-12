# Vcenter.ViJson.OpenApi.Model.NoCompatibleHost

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | The list of hosts that are not compatible, each element has a corresponding fault in the error array.  Refers instances of *HostSystem*.  | [optional] 
**Error** | [**List&lt;MethodFault&gt;**](MethodFault.md) | An error in this array indicates why the corresponding host in the host array is incompatible.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

