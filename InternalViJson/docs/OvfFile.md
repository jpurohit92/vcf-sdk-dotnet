# Vcenter.ViJson.OpenApi.Model.OvfFile

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeviceId** | **string** | The ID of the device backed by this file.  This ID uniquely identifies the device within the entity hierarchy.  The caller will have received this along with the URL needed to download the file (this is handled by another service interface).  | 
**Path** | **string** | The path chosen by the caller for this file.  This path becomes the value of the \&quot;href\&quot; attribute of the corresponding \&quot;File\&quot; element in the OVF descriptor.  This path must be relative to the path chosen for the OVF descriptor. This implies that the caller must decide in advance on the path to which it will write the OVF descriptor, once it is returned.  The folder separator must be \&quot;/\&quot; (forward slash).  The path must not begin with a slash - ie. it must not be an absolute path.  | 
**CompressionMethod** | **string** | The compression method the caller chose to employ for this file.  | [optional] 
**ChunkSize** | **long** | The chunksize chosen by the caller.  When using chunking, the caller must adhere to the method described in the OVF specification.  | [optional] 
**Size** | **long** | The file size, as observed by the caller during download.  | 
**Capacity** | **long** | The capacity of the disk backed by this file.  This should only be set if the device backed by this file is a disk. This value will be written in the \&quot;capacity\&quot; attribute of the corresponding \&quot;Disk\&quot; element in the OVF descriptor.  Note that the \&quot;capacity\&quot; attribute is normally set to the capacity of the corresponding *VirtualDisk*. Setting this variable overrides the capacity from the VirtualDisk.  | [optional] 
**PopulatedSize** | **long** | The populated size of the disk backed by this file.  This should only be set if the device backed by this file is a disk. This value will be written in the \&quot;populatedSize\&quot; attribute of the corresponding \&quot;Disk\&quot; element in the OVF descriptor.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

