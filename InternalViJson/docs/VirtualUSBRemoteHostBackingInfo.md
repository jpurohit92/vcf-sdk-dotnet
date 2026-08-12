# Vcenter.ViJson.OpenApi.Model.VirtualUSBRemoteHostBackingInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeviceName** | **string** | The name of the device on the host system.  | 
**UseAutoDetect** | **bool** | Indicates whether the device should be auto detected instead of directly specified.  If this value is set to TRUE, deviceName is ignored.  | [optional] 
**Hostname** | **string** | Name of the ESX host to which the physical USB device is attached (*HostSystem*.*ManagedEntity.name*).  When you configure remote host backing, hostname must identify the local host on which the virtual machine is running.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

