# Vcenter.ViJson.OpenApi.Model.OvfFileItem

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeviceId** | **string** | Uniquely identifies the device (disk, CD-ROM etc.) within the entity hierarchy.  When *ResourcePool.importVApp* is called to create the *VirtualMachine*s and *VirtualApp*s, it returns a map, device ID -&amp;gt; URL, of where to upload the backing files.  | 
**Path** | **string** | The path of the item to upload, relative to the path of the OVF descriptor.  | 
**CompressionMethod** | **string** | The compression method as specified by the OVF specification (for example \&quot;gzip\&quot; or \&quot;bzip2\&quot;).  | [optional] 
**ChunkSize** | **long** | The chunksize as specified by the OVF specification.  If this attribute is set, the \&quot;path\&quot; attribute is a prefix to each chunk of the complete file. For example, if chunksize is 2000000000 bytes, the actual files might be: myfile.000000000 (2000000000 bytes) myfile.000000001 (2000000000 bytes) myfile.000000002 (1500000000 bytes)  | [optional] 
**Size** | **long** | The complete size of the file, if it is specified in the OVF descriptor.  | [optional] 
**CimType** | **int** | The CIM type of the device for which this file provides backing.  For example, the value 17 means \&quot;Disk drive\&quot;.  | 
**Create** | **bool** | True if the item is not expected to exist in the infrastructure and should therefore be created by the caller (for example using HTTP PUT).  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

