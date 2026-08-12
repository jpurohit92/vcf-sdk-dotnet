# Vcenter.ViJson.OpenApi.Model.DistributedVirtualSwitchManagerCompatibilityResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | The host for which results are annotated.  The whole object will be filtered out if the caller did not have view permissions on the host entity.  Refers instance of *HostSystem*.  | 
**Error** | [**List&lt;MethodFault&gt;**](MethodFault.md) | This property contains the faults that makes the host not compatible with a given DvsProductSpec.  For example, a host might not be compatible because it&#39;s an older version of ESX that doesn&#39;t support DVS.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

