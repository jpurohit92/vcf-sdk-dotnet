# Vcenter.ViJson.OpenApi.Model.VirtualMachineBootOptions

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BootDelay** | **long** | Delay in milliseconds before starting the boot sequence.  The boot delay specifies a time interval between virtual machine power on or restart and the beginning of the boot sequence.  | [optional] 
**EnterBIOSSetup** | **bool** | If set to &lt;code&gt;true&lt;/code&gt;, the virtual machine automatically enters BIOS setup the next time it boots.  The virtual machine resets this flag to &lt;code&gt;false&lt;/code&gt; so that subsequent boots proceed normally.  | [optional] 
**EfiSecureBootEnabled** | **bool** | If set to &lt;code&gt;true&lt;/code&gt;, the virtual machine&#39;s firmware will perform signature checks of any EFI images loaded during startup, and will refuse to start any images which do not pass those signature checks.  When creating a new VM: \\- If vim.vm.FlagInfo.vbsEnabled is set to &lt;code&gt;true&lt;/code&gt;, and this flag is set to &lt;code&gt;false&lt;/code&gt; error is returned. \\- If this flag is unset and vim.vm.FlagInfo.vbsEnabled is set to &lt;code&gt;true&lt;/code&gt;, the value of this flag is set to &lt;code&gt;true&lt;/code&gt;.  | [optional] 
**BootRetryEnabled** | **bool** | If set to &lt;code&gt;true&lt;/code&gt;, a virtual machine that fails to boot will try again after the *VirtualMachineBootOptions.bootRetryDelay* time period has expired.  When &lt;code&gt;false&lt;/code&gt;, the virtual machine waits indefinitely for you to initiate boot retry.  | [optional] 
**BootRetryDelay** | **long** | Delay in milliseconds before a boot retry.  The boot retry delay specifies a time interval between virtual machine boot failure and the subsequent attempt to boot again. The virtual machine uses this value only if *VirtualMachineBootOptions.bootRetryEnabled* is true.  | [optional] 
**BootOrder** | [**List&lt;VirtualMachineBootOptionsBootableDevice&gt;**](VirtualMachineBootOptionsBootableDevice.md) | Boot order.  Listed devices are used for booting. After list is exhausted, default BIOS boot device algorithm is used for booting. Note that order of the entries in the list is important: device listed first is used for boot first, if that one fails second entry is used, and so on. Platform may have some internal limit on the number of devices it supports. If bootable device is not reached before platform&#39;s limit is hit, boot will fail. At least single entry is supported by all products supporting boot order settings.  | [optional] 
**NetworkBootProtocol** | **string** | Protocol to attempt during PXE network boot or NetBoot.  See also *VirtualMachineBootOptionsNetworkBootProtocolType_enum*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

