# Vcenter.ViJson.OpenApi.Model.HbrDiskMigrationAction

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Type of the action.  This is encoded to differentiate between different types of actions aimed at achieving different goals.  | 
**Target** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target object on which this action will be applied.  For instance, a migration action will have a virtual machine as its target object, while a host power action will have a host as its target action.  | [optional] 
**CollectionId** | **string** | HMS Service specific collection id  | 
**CollectionName** | **string** | HMS specific name of this collection  | 
**DiskIds** | **List&lt;string&gt;** | HBR disk ids of secondary disks moved by this action  | 
**Source** | [**ManagedObjectReference**](ManagedObjectReference.md) | Source datastore.  Refers instance of *Datastore*.  | 
**Destination** | [**ManagedObjectReference**](ManagedObjectReference.md) | Destination datastore.  Refers instance of *Datastore*.  | 
**SizeTransferred** | **long** | The amount of data to be transferred.  Unit: KB.  | 
**SpaceUtilSrcBefore** | **float** | Space utilization on the source datastore before storage migration.  Unit: percentage. For example, if set to 70.0, space utilization is 70%. If not set, the value is not available.  | [optional] 
**SpaceUtilDstBefore** | **float** | Space utilization on the destination datastore before storage migration.  Unit: percentage. For example, if set to 70.0, space utilization is 70%. If not set, the value is not available.  | [optional] 
**SpaceUtilSrcAfter** | **float** | Expected space utilization on the source datastore after storage migration.  Unit: percentage. For example, if set to 70.0, space utilization is 70%. If not set, the value is not available.  | [optional] 
**SpaceUtilDstAfter** | **float** | Expected space utilization on the destination datastore after storage migration.  Unit: percentage. For example, if set to 70.0, space utilization is 70%. If not set, the value is not available.  | [optional] 
**IoLatencySrcBefore** | **float** | Deprecated as of vSphere8.0 U3, and there is no replacement for it.  I/O latency on the source datastore before storage migration.  Unit: millisecond. If not set, the value is not available.  | [optional] 
**IoLatencyDstBefore** | **float** | Deprecated as of vSphere8.0 U3, and there is no replacement for it.  I/O latency on the destination datastore before storage migration.  Unit: millisecond. If not set, the value is not available.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

