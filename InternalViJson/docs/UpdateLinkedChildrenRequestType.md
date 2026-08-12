# Vcenter.ViJson.OpenApi.Model.UpdateLinkedChildrenRequestType
The parameters of *VirtualApp.UpdateLinkedChildren*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddChangeSet** | [**List&lt;VirtualAppLinkInfo&gt;**](VirtualAppLinkInfo.md) | a set of LinkInfo objects that either add a new link or modify an existing link.  | [optional] 
**RemoveSet** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | a set of entities that should no longer link to this vApp.  Refers instances of *ManagedEntity*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

