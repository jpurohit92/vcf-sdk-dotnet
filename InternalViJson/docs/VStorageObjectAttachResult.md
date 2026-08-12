# Vcenter.ViJson.OpenApi.Model.VStorageObjectAttachResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VolumeId** | [**ID**](ID.md) | The ID of the operated volume See *ID*  | 
**DiskUUID** | **string** | UUID for disk, value is obtained from vm config and can be used during mounting.  This field will be set in case of a successful attach operation. When fault field is set, this value will not be set and should be ignored.  | [optional] 
**Fault** | [**MethodFault**](MethodFault.md) | Fault, if any, corresponding to the specified volume ID that caused operation to fail.  Absence of fault will indicate successful result.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

