# Vcenter.Automation.OpenApi.Model.VcenterVmToolsGuestRebootStatus
The Vcenter.Vm.Tools.GuestRebootStatus schema describes the guest operating system reboot status resulting from a VMware Tools install, upgrade, or uninstall.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RebootRequested** | **bool** | Indicates whether a VMware Tools install, upgrade, or uninstall requires a reboot of the guest operating system. Set to true when a VMware Tools install, upgrade, or uninstall has requested the guest operating system to be rebooted and no reboot has been performed since the request. It is set to false as soon as the guest operating system completes a reboot following the request.  This property was added in __vSphere API 9.1.0.0__. | 
**RequestingComponents** | **List&lt;string&gt;** | List of VMware Tools and/or system components that have requested the guest OS be rebooted to complete a VMware Tools install, upgrade, or uninstall. See the VMware Tools Administration Guide for the details of the components reported by the install operation.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60; no reboot is pending, or the reboot components list information is not available. For older versions of VMware Tools or ESXi, the information is not available. For uninstall operations, the information is not available. | [optional] 
**RequestTimestamp** | **DateTime** | The time when the reboot request was generated.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60; no reboot is pending, or the reboot request time is not available. For older versions of VMware Tools or ESXi, the information is not available. For uninstall operations, the information is not available. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

