# Vcenter.ViJson.OpenApi.Model.VStorageObjectConfigInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ID**](ID.md) | ID of this object.  | 
**Name** | **string** | Descriptive name of this object.  | 
**CreateTime** | **DateTime** | The date and time this object was created.  | 
**KeepAfterDeleteVm** | **bool** | Choice of the deletion behavior of this virtual storage object.  If not set, the default value is false.  | [optional] 
**RelocationDisabled** | **bool** | Is virtual storage object relocation disabled.  If not set, the default value is false.  | [optional] 
**NativeSnapshotSupported** | **bool** | Is virtual storage object supports native snapshot.  If not set, the default value is false.  | [optional] 
**ChangedBlockTrackingEnabled** | **bool** | If Virtual storage object has changed block tracking enabled.  If not set, the default value is false.  | [optional] 
**Backing** | [**BaseConfigInfoBackingInfo**](BaseConfigInfoBackingInfo.md) | Backing of this object.  | 
**Metadata** | [**List&lt;KeyValue&gt;**](KeyValue.md) | Metadata associated with the FCD if available.  ***Since:*** vSphere API Release 7.0.2.0  | [optional] 
**Vclock** | [**VslmVClockInfo**](VslmVClockInfo.md) | VClock associated with the fcd when the operation completed.  The files is unset if the operation is a retrieve.  ***Since:*** vSphere API Release 7.0.2.0  | [optional] 
**Iofilter** | **List&lt;string&gt;** | IDs of the IO Filters associated with the virtual disk.  See *IoFilterInfo.id*. The client cannot modify this information on a virtual machine.  | [optional] 
**DescriptorVersion** | **int** | The descriptor version of this object  ***Since:*** vSphere API Release 8.0.1.0  | [optional] 
**CapacityInMB** | **long** | The size in MB of this object.  | 
**ConsumptionType** | **List&lt;string&gt;** | Consumption type of this object.  See also *VStorageObjectConsumptionType_enum*.  | [optional] 
**ConsumerId** | [**List&lt;ID&gt;**](ID.md) | IDs of the consumer objects which consume this vstorage object.  For a virtual disk, this can be VM ID(s).  | [optional] 
**VirtualDiskFormat** | **string** | The type of VirtualDisk for 4k native disk/array support.  See *DatastoreSectorFormat_enum* for definitions of supported types. If not set, the default value is *native_512*.  ***Since:*** vSphere API Release 9.0.0.0  | [optional] 
**LinkedCloneBasePath** | **string** | Base disk path of a linked clone disk.  Unset, if the virtual storage object is not a linked clone.  ***Since:*** vSphere API Release 9.1.0.0  | [optional] 
**LinkedCloneParentId** | [**ID**](ID.md) | The ID of the parent virtual storage object this linked clone virtual storage object.  Unset, if the virtual storage object is not a linked clone or if the parent of the linked clone is a vanilla disk  ***Since:*** vSphere API Release 9.1.0.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

