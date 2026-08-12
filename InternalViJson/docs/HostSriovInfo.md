# Vcenter.ViJson.OpenApi.Model.HostSriovInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The name ID of this PCI, composed of \&quot;bus:slot.function\&quot;.  | 
**DependentDevice** | **string** | Device which needs to be unclaimed by vmkernel (may be bridge)  | 
**PassthruEnabled** | **bool** | Whether passThru has been configured by the user  | 
**PassthruCapable** | **bool** | Whether passThru is even possible for this device (decided by vmkctl)  | 
**PassthruActive** | **bool** | Whether passThru is active for this device (meaning enabled + rebooted)  | 
**HardwareLabel** | **string** | The hardware label of this PCI device.  ***Since:*** vSphere API Release 7.0.2.0  | [optional] 
**DirectPathState** | [**HostPciPassthruInfoDirectPathState**](HostPciPassthruInfoDirectPathState.md) | Information about physical device that can provide resources for virtual machines.  ***Since:*** vSphere API Release 9.1.0.0  | [optional] 
**SriovEnabled** | **bool** | Whether SRIOV has been enabled by the user  | 
**SriovCapable** | **bool** | Whether SRIOV is possible for this device  | 
**SriovActive** | **bool** | Whether SRIOV is active for this device (meaning enabled + rebooted)  | 
**NumVirtualFunctionRequested** | **int** | Number of SRIOV virtual functions requested for this device  | 
**NumVirtualFunction** | **int** | Number of SRIOV virtual functions present on this device  | 
**MaxVirtualFunctionSupported** | **int** | Maximum number of SRIOV virtual functions supported on this device  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

