# Vcenter.ViJson.OpenApi.Model.VAppCloneSpecResourceMap

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Source** | [**ManagedObjectReference**](ManagedObjectReference.md) | Source entity  Refers instance of *ManagedEntity*.  | 
**Parent** | [**ManagedObjectReference**](ManagedObjectReference.md) | Resource pool to use for the cloned entity of source.  This must specify a resource pool that is not part of the vApp. If this is specified, a linked child (as opposed to a direct child) is created for the vApp.  Refers instance of *ResourcePool*.  | [optional] 
**ResourceSpec** | [**ResourceConfigSpec**](ResourceConfigSpec.md) | An optional resource configuration for the cloned entity of the source.  If not specified, the same resource configuration as the source is used.  | [optional] 
**Location** | [**ManagedObjectReference**](ManagedObjectReference.md) | A client can optionally specify a datastore in the resource map to override the default datastore location set in *VAppCloneSpecResourceMap.location* field.  This enables cloning to different compute resources that do not have shared datastores.  Refers instance of *Datastore*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

