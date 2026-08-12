# Vcenter.ViJson.OpenApi.Model.BaseConfigInfo

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

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

