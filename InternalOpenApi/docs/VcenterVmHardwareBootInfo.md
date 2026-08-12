# Vcenter.Automation.OpenApi.Model.VcenterVmHardwareBootInfo
The Vcenter.Vm.Hardware.Boot.Info schema contains information about the virtual machine boot process.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Firmware type used by the virtual machine.  Possible values:   - &#x60;BIOS&#x60;: Basic Input/Output System (BIOS) firmware.   - &#x60;EFI&#x60;: Extensible Firmware Interface (EFI) firmware.   For more information see: *Vcenter.Vm.Hardware.Boot.Type*. | 
**EfiLegacyBoot** | **bool** | Flag indicating whether to use EFI legacy boot mode.  This property is optional and it is only relevant when the value of type is *Vcenter.Vm.Hardware.Boot.Type.EFI*. | [optional] 
**NetworkProtocol** | **string** | Protocol to use when attempting to boot the virtual machine over the network.  Possible values:   - &#x60;IPV4&#x60;: PXE or Apple NetBoot over IPv4.   - &#x60;IPV6&#x60;: PXE over IPv6.   For more information see: *Vcenter.Vm.Hardware.Boot.NetworkProtocol*.  This property is optional and it is only relevant when the value of type is *Vcenter.Vm.Hardware.Boot.Type.EFI*. | [optional] 
**Delay** | **long** | Delay in milliseconds before beginning the firmware boot process when the virtual machine is powered on. This delay may be used to provide a time window for users to connect to the virtual machine console and enter BIOS setup mode. | 
**Retry** | **bool** | Flag indicating whether the virtual machine will automatically retry the boot process after a failure. | 
**RetryDelay** | **long** | Delay in milliseconds before retrying the boot process after a failure; applicable only when *Vcenter.Vm.Hardware.Boot.Info.retry* is true. | 
**EnterSetupMode** | **bool** | Flag indicating whether the firmware boot process will automatically enter setup mode the next time the virtual machine boots. Note that this flag will automatically be reset to false once the virtual machine enters setup mode. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

