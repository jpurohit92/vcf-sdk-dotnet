# Vcenter.ViJson.OpenApi.Model.VsanDeleteObjectsRequestType
The parameters of *VsanObjectSystem.VsanDeleteObjects_Task*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | vSAN cluster. Ignored if called against host.  ***Required privileges:*** Host.Config.Storage  Refers instance of *ComputeResource*.  | [optional] 
**ObjUuids** | **List&lt;string&gt;** | The vSAN object UUIDs to delete.  | 
**Force** | **bool** | The force flag, inaccessible objects can&#39;t be deleted without this flag. WARNING: it&#39;s at your own risk.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

