# Vcenter.ViJson.OpenApi.Model.HostRdmaDevice

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | The linkable identifier.  | 
**Device** | **string** | The device name of the RDMA device.  | 
**Driver** | **string** | The short string name of the device driver, if available.  | [optional] 
**Description** | **string** | Device description, if available.  | [optional] 
**Backing** | [**HostRdmaDeviceBacking**](HostRdmaDeviceBacking.md) | If set, represents the physical backing for the RDMA device.  Not all RDMA devices are required to have a physical backing.  | [optional] 
**ConnectionInfo** | [**HostRdmaDeviceConnectionInfo**](HostRdmaDeviceConnectionInfo.md) | Current device connection state.  | 
**Capability** | [**HostRdmaDeviceCapability**](HostRdmaDeviceCapability.md) | Supported capabilities of the RDMA device.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

