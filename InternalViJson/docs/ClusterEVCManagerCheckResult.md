# Vcenter.ViJson.OpenApi.Model.ClusterEVCManagerCheckResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EvcModeKey** | **string** | The EVC mode being tested for legal application.  | 
**Error** | [**MethodFault**](MethodFault.md) | A problem that would prevent applying the desired EVC mode.  | 
**Host** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | The set of hosts which would generate the fault described by the *ClusterEVCManagerCheckResult.error* property when the desired EVC mode is applied.  Refers instances of *HostSystem*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

