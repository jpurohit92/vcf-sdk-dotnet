# Vcenter.Automation.OpenApi.Model.VcenterVmHardwareBootUpdateSpec
The Vcenter.Vm.Hardware.Boot.UpdateSpec schema describes the updates to the settings used when booting a virtual machine.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Firmware type to be used by the virtual machine.  Possible values:   - &#x60;BIOS&#x60;: Basic Input/Output System (BIOS) firmware.   - &#x60;EFI&#x60;: Extensible Firmware Interface (EFI) firmware.   For more information see: *Vcenter.Vm.Hardware.Boot.Type*.  If missing or &#x60;null&#x60;, the value is unchanged. | [optional] 
**EfiLegacyBoot** | **bool** | Flag indicating whether to use EFI legacy boot mode.  If missing or &#x60;null&#x60;, the value is unchanged. | [optional] 
**NetworkProtocol** | **string** | Protocol to use when attempting to boot the virtual machine over the network.  Possible values:   - &#x60;IPV4&#x60;: PXE or Apple NetBoot over IPv4.   - &#x60;IPV6&#x60;: PXE over IPv6.   For more information see: *Vcenter.Vm.Hardware.Boot.NetworkProtocol*.  If missing or &#x60;null&#x60;, the value is unchanged. | [optional] 
**Delay** | **long** | Delay in milliseconds before beginning the firmware boot process when the virtual machine is powered on. This delay may be used to provide a time window for users to connect to the virtual machine console and enter BIOS setup mode.  If missing or &#x60;null&#x60;, the value is unchanged. | [optional] 
**Retry** | **bool** | Flag indicating whether the virtual machine should automatically retry the boot process after a failure.  If missing or &#x60;null&#x60;, the value is unchanged. | [optional] 
**RetryDelay** | **long** | Delay in milliseconds before retrying the boot process after a failure; applicable only when *Vcenter.Vm.Hardware.Boot.Info.retry* is true.  If missing or &#x60;null&#x60;, the value is unchanged. | [optional] 
**EnterSetupMode** | **bool** | Flag indicating whether the firmware boot process should automatically enter setup mode the next time the virtual machine boots. Note that this flag will automatically be reset to false once the virtual machine enters setup mode.  If missing or &#x60;null&#x60;, the value is unchanged. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

