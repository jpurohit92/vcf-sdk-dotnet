# Vcenter.ViJson.OpenApi.Model.VAppCloneSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Location** | [**ManagedObjectReference**](ManagedObjectReference.md) | Location where the destination vApp must be stored  Refers instance of *Datastore*.  | 
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target host for the virtual machines.  This is often not a required parameter. If not specified, the behavior is as follows: - If the target pool represents a stand-alone host, that host is used. - If the target pool represents a DRS-enabled cluster, a host selected   by DRS is used. - If the target pool represents a cluster without DRS enabled or a   DRS-enabled cluster in manual mode, an InvalidArgument exception is   thrown.    Refers instance of *HostSystem*.  | [optional] 
**ResourceSpec** | [**ResourceConfigSpec**](ResourceConfigSpec.md) | The resource configuration for the vApp.  | [optional] 
**VmFolder** | [**ManagedObjectReference**](ManagedObjectReference.md) | The VM Folder to associate the vApp with  Refers instance of *Folder*.  | [optional] 
**NetworkMapping** | [**List&lt;VAppCloneSpecNetworkMappingPair&gt;**](VAppCloneSpecNetworkMappingPair.md) | Network mappings.  See *VAppCloneSpecNetworkMappingPair*.  | [optional] 
**Property** | [**List&lt;KeyValue&gt;**](KeyValue.md) | A set of property values to override.  | [optional] 
**ResourceMapping** | [**List&lt;VAppCloneSpecResourceMap&gt;**](VAppCloneSpecResourceMap.md) | The resource configuration for the cloned vApp.  | [optional] 
**Provisioning** | **string** | Specify how the VMs in the vApp should be provisioned.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

