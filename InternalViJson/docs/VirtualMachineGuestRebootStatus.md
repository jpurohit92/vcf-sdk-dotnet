# Vcenter.ViJson.OpenApi.Model.VirtualMachineGuestRebootStatus

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RebootRequested** | **bool** | Indicates whether a VMware Tools install, upgrade, or uninstall requires a reboot of the guest operating system.  Set to true when a VMware Tools install, upgrade, or uninstall has requested the guest operating system to be rebooted and no reboot has been performed since the request. It is set to false as soon as the guest operating system completes a reboot following the request.  | 
**RequestingComponents** | **List&lt;string&gt;** | List of VMware Tools and/or system components that have requested the guest operating system be rebooted to complete a VMware Tools install, upgrade, or uninstall.  See the VMware Tools Administration Guide for the details of the components reported by the install operation. If unset, no reboot is pending, or the reboot components list information is not available. For older versions of VMware Tools or ESXi, the information is not available. For uninstall operations, the information is not available.  | [optional] 
**RequestTimestamp** | **DateTime** | The time when the reboot request was generated.  If unset, no reboot is pending, or the reboot time information is not available. For older versions of VMware Tools or ESXi, the information is not available. For uninstall operations, the information is not available.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

