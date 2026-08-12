# Vcenter.ViJson.OpenApi.Model.CnsVolumeAttachResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VolumeId** | [**CnsVolumeId**](CnsVolumeId.md) | Unique identifier and datastore information for the volume.     Result object for all operations, other than create, will get volumeId as part of its input parameter and should always have this field set. For the result of create operation, this field will not be set. Please see *CnsVolumeCreateResult* for details.  | [optional] 
**Fault** | [**MethodFault**](MethodFault.md) | Fault, if any, corresponding to the specified volume ID that caused operation to fail.  Absence of fault will indicate successful result.    For create operation, volumeId field will not be set. Instead, volume name will be set, to associated fault with appropriate request. Please see *CnsVolumeCreateResult* for details.  | [optional] 
**DiskUUID** | **string** | UUID for disk, coming via SCSI vital product data (VPD) page 0x83 for the block backing of this volume.     This UUID can be used to identify this disk on the VM, e.g. for mounting purpose. This field will be set in case of a successful attach operation. When fault field is set, this value will not be set and should be ignored.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

