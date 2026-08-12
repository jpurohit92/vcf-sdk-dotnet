# Vcenter.ViJson.OpenApi.Model.HostSerialAttachedHba

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | The linkable identifier.  | [optional] 
**Device** | **string** | The device name of host bus adapter.  | 
**Bus** | **int** | The host bus number.  | 
**Status** | **string** | The operational status of the adapter.  Valid values include \&quot;online\&quot;, \&quot;offline\&quot;, \&quot;unbound\&quot;, and \&quot;unknown\&quot;.  | 
**Model** | **string** | The model name of the host bus adapter.  | 
**Driver** | **string** | The name of the driver.  | [optional] 
**Pci** | **string** | The Peripheral Connect Interface (PCI) ID of the device representing the host bus adapter.  | [optional] 
**StorageProtocol** | **string** | The type of protocol supported by the host bus adapter.  The list of supported values is described in *HostStorageProtocol_enum*. When unset, a default value of \&quot;scsi\&quot; is assumed.  | [optional] 
**DriverVersion** | **string** | The host bus adapter driver version.  ***Since:*** vSphere API Release 9.1.0.0  | [optional] 
**FirmwareVersion** | **string** | The host bus adapter firmware version.  ***Since:*** vSphere API Release 9.1.0.0  | [optional] 
**NodeWorldWideName** | **string** | The world wide node name for the adapter.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

