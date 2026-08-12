# Vcenter.ViJson.OpenApi.Model.DatastoreSummary

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Datastore** | [**ManagedObjectReference**](ManagedObjectReference.md) | The reference to the managed object.  Refers instance of *Datastore*.  | [optional] 
**Name** | **string** | The name of the datastore.  | 
**Url** | **string** | The unique locator for the datastore.  This property is guaranteed to be valid only if *DatastoreSummary.accessible* is true.  | 
**Capacity** | **long** | Maximum capacity of this datastore, in bytes.  This value is updated periodically by the server. It can be explicitly refreshed with the Refresh operation. This property is guaranteed to be valid only if *DatastoreSummary.accessible* is true.  | 
**FreeSpace** | **long** | Available space of this datastore, in bytes.  The server periodically updates this value. It can be explicitly refreshed with the Refresh operation. This property is guaranteed to be valid only if *DatastoreSummary.accessible* is true.  | 
**Uncommitted** | **long** | Total additional storage space, in bytes, potentially used by all virtual machines on this datastore.  The server periodically updates this value. It can be explicitly refreshed with the *Datastore.RefreshDatastoreStorageInfo* operation. This property is valid only if *DatastoreSummary.accessible* is true.  | [optional] 
**Accessible** | **bool** | The connectivity status of this datastore.  If this is set to false, meaning the datastore is not accessible, this datastore&#39;s capacity and freespace properties cannot be validated. Furthermore, if this property is set to false, some of the properties in this summary and in *DatastoreInfo* should not be used. Refer to the documentation for the property of your interest. For datastores accessed from multiple hosts, vCenter Server reports *DatastoreSummary.accessible* as an aggregated value of the properties reported in *HostMountInfo*. For instance, if a datastore is accessible through a subset of hosts, then the value of *DatastoreSummary.accessible* will be reported as true by vCenter Server. And the reason for a daastore being inaccessible from a host will be reported in *HostMountInfo.inaccessibleReason*  | 
**MultipleHostAccess** | **bool** | More than one host in the datacenter has been configured with access to the datastore.  This is only provided by VirtualCenter.  | [optional] 
**Type** | **string** | Type of file system volume, such as VMFS or NFS.  See also *HostFileSystemVolume.type*.  | 
**MaintenanceMode** | **string** | The current maintenance mode state of the datastore.  The set of possible values is described in *DatastoreSummaryMaintenanceModeState_enum*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

