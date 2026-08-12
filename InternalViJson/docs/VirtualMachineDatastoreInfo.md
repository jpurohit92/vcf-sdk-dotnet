# Vcenter.ViJson.OpenApi.Model.VirtualMachineDatastoreInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The identification of the endpoint on the host.  The format of this depends on the kind of virtual device this endpoints is used for. For example, for a VirtualEthernetCard this would be a networkname, and for a VirtualCDROM it would be a device name.  | 
**ConfigurationTag** | **List&lt;string&gt;** | List of configurations that this device is available for.  This is only filled out if more than one configuration is requested.  | [optional] 
**Datastore** | [**DatastoreSummary**](DatastoreSummary.md) | Information about the datastore  | 
**Capability** | [**DatastoreCapability**](DatastoreCapability.md) | Information about the datastore capabilities  | 
**MaxFileSize** | **long** | The maximum size of a file that can reside on this datastore.  | 
**MaxVirtualDiskCapacity** | **long** | The maximum capacity of a virtual disk which can be created on this volume  | [optional] 
**MaxPhysicalRDMFileSize** | **long** | Maximum raw device mapping size (physical compatibility)  | [optional] 
**MaxVirtualRDMFileSize** | **long** | Maximum raw device mapping size (virtual compatibility)  | [optional] 
**Mode** | **string** | Access mode for this datastore.  This is either readOnly or readWrite. A virtual disk needs to be stored on readWrite datastore. ISOs can be read from a readOnly datastore.  See also *HostMountMode_enum*.  | 
**VStorageSupport** | **string** | Indicate the states of vStorage hardware acceleration support for this datastore.  In the case of a cluster compute resource, this property is aggregated from the values reported by individual hosts as follows: - If at least one host reports   *vStorageSupported*,   then it is set to   *vStorageSupported*. - Else if at least one host reports   *vStorageUnknown*,   it is set to   *vStorageUnknown*. - Else if at least one host reports   *vStorageUnsupported*,   it is set to   *vStorageUnsupported*. - Else it is unset.    See also *FileSystemMountInfoVStorageSupportStatus_enum*.  | [optional] 
**SupportedVDiskFormats** | **List&lt;string&gt;** | A list of virtual disk format types which are supported on that datastore.  See *DatastoreSectorFormat_enum* for the list of supported types.  ***Since:*** vSphere API Release 9.0.0.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

