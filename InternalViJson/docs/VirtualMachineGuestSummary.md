# Vcenter.ViJson.OpenApi.Model.VirtualMachineGuestSummary

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GuestId** | **string** | Guest operating system identifier (short name), if known.  | [optional] 
**GuestFullName** | **string** | Guest operating system name configured on the virtual machine.  | [optional] 
**ToolsStatus** | **VirtualMachineToolsStatusEnum** | Deprecated as of vSphere API 5.0 use *VirtualMachineGuestSummary.toolsVersionStatus2* and *VirtualMachineGuestSummary.toolsRunningStatus*.  Current status of VMware Tools in the guest operating system, if known.  | [optional] 
**ToolsVersionStatus** | **string** | Deprecated as of vSphere API 5.0 use *VirtualMachineGuestSummary.toolsVersionStatus2*.  Current version status of VMware Tools in the guest operating system, if known.  | [optional] 
**ToolsVersionStatus2** | **string** | Current version status of VMware Tools in the guest operating system, if known.  | [optional] 
**ToolsRunningStatus** | **string** | Current running status of VMware Tools in the guest operating system, if known.  | [optional] 
**HostName** | **string** | Hostname of the guest operating system, if known.  | [optional] 
**IpAddress** | **string** | Primary IP address assigned to the guest operating system, if known.  | [optional] 
**HwVersion** | **string** | The hardware version string for this virtual machine.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

