# Vcenter.ViJson.OpenApi.Model.VirtualMachineFileLayoutExDiskLayout

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **int** | Identifier for the virtual disk in *VirtualHardware.device*.  | 
**VirtualDiskFormat** | **string** | The sector format of the virtual disk.  See *DatastoreSectorFormat_enum* for definitions of supported types. If not set, the default value is *native_512*.  ***Since:*** vSphere API Release 9.0.0.0  | [optional] 
**Chain** | [**List&lt;VirtualMachineFileLayoutExDiskUnit&gt;**](VirtualMachineFileLayoutExDiskUnit.md) | The disk-unit chain that makes up this virtual disk.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

