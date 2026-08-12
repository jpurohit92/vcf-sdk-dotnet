# Vcenter.ViJson.OpenApi.Model.VirtualDiskLocalPMemBackingInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FileName** | **string** | Filename for the host file used in this backing.  | 
**Datastore** | [**ManagedObjectReference**](ManagedObjectReference.md) | Reference to the datastore managed object where this file is stored.  If the file is not located on a datastore, then this reference is null. This is not used for configuration.  Refers instance of *Datastore*.  | [optional] 
**BackingObjectId** | **string** | Backing object&#39;s durable and unmutable identifier.  Each backing object has a unique identifier which is not settable.  | [optional] 
**DiskMode** | **string** | The disk persistence mode.  See also *VirtualDiskMode_enum*.  | 
**Uuid** | **string** | Disk UUID for the virtual disk, if available.  | [optional] 
**VolumeUUID** | **string** | Persistent memory volume UUID - UUID which associates this virtual disk with a specific host.  This is read only property.  See also *HostPersistentMemoryInfo.volumeUUID*.  | [optional] 
**ContentId** | **string** | Content ID of the virtual disk file, if available.  A content ID indicates the logical contents of the disk backing and its parents.  This property is only guaranteed to be up to date if this disk backing is not currently being written to by any virtual machine.  The only supported operation is comparing if two content IDs are equal or not. The guarantee provided by the content ID is that if two disk backings have the same content ID and are not currently being written to, then reads issued from the guest operating system to those disk backings will return the same data.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

