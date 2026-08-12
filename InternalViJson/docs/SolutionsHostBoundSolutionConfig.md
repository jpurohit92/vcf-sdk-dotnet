# Vcenter.ViJson.OpenApi.Model.SolutionsHostBoundSolutionConfig

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PreferHostConfiguration** | **bool** | If set to true - default network and datastore configured on host will take precedence over *SolutionsHostBoundSolutionConfig.datastores* and *SolutionsHostBoundSolutionConfig.networks*.  | [optional] 
**Networks** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | networks to satisfy system Virtual Machine network adapter requirements.  If omitted - default configured network on the host will be used.  Refers instances of *Network*.  | [optional] 
**Datastores** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | Datastores to be configured as a storage of the VMs.  The first available datastore on the host is used. The collection cannot contain duplicate elements. If omitted - default configured datastore on the host will be used.  Refers instances of *Datastore*.  | [optional] 
**Vmci** | **List&lt;string&gt;** | VMCI to be allowed access from the system Virtual Machine.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

