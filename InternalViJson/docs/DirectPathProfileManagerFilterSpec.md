# Vcenter.ViJson.OpenApi.Model.DirectPathProfileManagerFilterSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Ids** | **List&lt;string&gt;** | Identifiers of the DirectPath profiles to be retrieved.  If a non-empty list of identifiers is specified while listing DirectPath profiles in a vCenter (see *DirectPathProfileManager.DirectPathProfileManagerList*), then information about every DirectPath profile whose identifier matches with one of the specified identifiers will be retrieved. In other words, if identifier of a DirectPath profile is not present in the specified list of identifiers, then that DirectPath profile will not be retrieved.  | [optional] 
**Names** | **List&lt;string&gt;** | Names of the DirectPath profiles to be retrieved.  If a non-empty list of names is specified while listing DirectPath profiles in a vCenter (see *DirectPathProfileManager.DirectPathProfileManagerList*) then information about every DirectPath profile whose name matches with one of the specified names will be retrieved. In other words, if name of a DirectPath profile is not present in the specified list of names, then that DirectPath profile will not be retrieved.  | [optional] 
**Clusters** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | MoRefs of the vSphere clusters for which DirectPath profiles need to be retrieved.  If a non-empty list of cluster MoRefs is specified while listing DirectPath profiles in a vCenter (see *DirectPathProfileManager.DirectPathProfileManagerList*), then information about the DirectPath profiles applicable to all the specified clusters is returned.  Refers instances of *ClusterComputeResource*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

