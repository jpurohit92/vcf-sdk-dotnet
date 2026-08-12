# Vcenter.ViJson.OpenApi.Model.VirtualMachineScsiDiskDeviceInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Capacity** | **long** | Size of disk  | [optional] 
**Vm** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | List of known virtual machines using this physical disk as a backing  Refers instances of *VirtualMachine*.  | [optional] 
**Disk** | [**HostScsiDisk**](HostScsiDisk.md) | Detailed information about the disk.  | [optional] 
**TransportHint** | **string** | Transport identifier hint used to identify the device.  To definitively correlate this device with a host physical disk, use the disk property. This identifier is intended as a hint to end users to identify the disk device.  | [optional] 
**LunNumber** | **int** | LUN number hint used to identify the SCSI device.  To definitively correlate this device with a host physical disk, use the disk property. This identifier is intended as a hint to end users to identify the disk device.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

