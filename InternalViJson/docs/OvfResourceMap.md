# Vcenter.ViJson.OpenApi.Model.OvfResourceMap

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Source** | **string** | Identifies a source VirtualSystem or VirtualSystemCollection in an OVF descriptor.  The source cannot be the root VirtualSystem or VirtualSystemCollection of the OVF. This is a path created by concatenating the OVF ids for each entity, e.g., \&quot;vm1\&quot;, \&quot;WebTier/vm2\&quot;, etc.  | 
**Parent** | [**ManagedObjectReference**](ManagedObjectReference.md) | The parent resource pool to use for the entity.  This must specify a resource pool that is not part of the vApp. If this is specified, a linked child (as opposed to a direct child) is created for the vApp.  Refers instance of *ResourcePool*.  | [optional] 
**ResourceSpec** | [**ResourceConfigSpec**](ResourceConfigSpec.md) | An optional resource configuration for the created entity.  If not specified, the resource configuration given in the OVF descriptor is used.  | [optional] 
**Datastore** | [**ManagedObjectReference**](ManagedObjectReference.md) | A client can optionally specify a datastore location in the resource map to override the default datastore passed into *OvfManager.CreateImportSpec* field.  This enables importing to different compute resources that do not have shared datastores.  Refers instance of *Datastore*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

