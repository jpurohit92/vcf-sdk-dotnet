# Vcenter.ViJson.OpenApi.Model.HostPtpConfigPtpPort

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Index** | **int** | Index into the list of PTP ports.  Supported values are in the range 0 through *HostCapability.maxSupportedPtpPorts*-1.  | 
**DeviceType** | **string** | Type of network device to be used with this port.  See *HostPtpConfigDeviceType_enum* for supported values. A device type of *none* indicates that this port is inactive.  | [optional] 
**Device** | **string** | Name of PTP capable network device to be used with this port.  Supported values depend on the type of network device used. For *virtualNic* this field is the name of a valid virtual NIC. See *HostVirtualNic*. For *pciPassthruNic* this field is a valid PCI device ID composed of \&quot;bus:slot.function\&quot;, enabled for PCI passthru. See *HostPciPassthruInfo*. For *none* this field is ignored.  | [optional] 
**IpConfig** | [**HostIpConfig**](HostIpConfig.md) | IP configuration of this port.  For *pciPassthruNic*, this field reflects current IP configuration, and it can be set. For *virtualNic*, this field reflects current IP configuration, but it cannot be set. To configure IP settings of a virtual NIC, see *HostVirtualNic*. For *none*, this field is ignored.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

