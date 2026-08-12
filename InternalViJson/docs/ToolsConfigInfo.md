# Vcenter.ViJson.OpenApi.Model.ToolsConfigInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ToolsVersion** | **int** | Version of VMware Tools installed on the guest operating system.  | [optional] 
**ToolsInstallType** | **string** | Installation type of VMware Tools in the guest operating system.  The set of possible values is described in *VirtualMachineToolsInstallType_enum*  | [optional] 
**AfterPowerOn** | **bool** | Flag to specify whether or not scripts should run after the virtual machine powers on.  | [optional] 
**AfterResume** | **bool** | Flag to specify whether or not scripts should run after the virtual machine resumes.  | [optional] 
**BeforeGuestStandby** | **bool** | Flag to specify whether or not scripts should run before the virtual machine suspends.  | [optional] 
**BeforeGuestShutdown** | **bool** | Flag to specify whether or not scripts should run before the virtual machine powers off.  | [optional] 
**BeforeGuestReboot** | **bool** | Flag to specify whether or not scripts should run before the virtual machine reboots.  | [optional] 
**ToolsUpgradePolicy** | **string** | Tools upgrade policy setting for the virtual machine.  See also *UpgradePolicy_enum*.  | [optional] 
**PendingCustomization** | **string** | When set, this indicates that a customization operation is pending on the VM.  The value represents the filename of the customization package on the host.  | [optional] 
**CustomizationKeyId** | [**CryptoKeyId**](CryptoKeyId.md) | When set, provides the id of the key used to encrypt the customization package attached to the VM.  | [optional] 
**SyncTimeWithHostAllowed** | **bool** | Indicates whether or not the tools program is allowed to synchronize guest time with host time.  When set to &lt;code&gt;false&lt;/code&gt;, disallows tool periodic time synchronization as well as guest time step corrections due to one-off events like resume from suspend.  ***Since:*** vSphere API Release 7.0.1.0  | [optional] 
**SyncTimeWithHost** | **bool** | Flag to specify whether or not the tools program will periodically synchronize guest time with host time.  Periodical synchronization is only allowed if *ToolsConfigInfo.syncTimeWithHostAllowed* is not set to &lt;code&gt;false&lt;/code&gt;.  | [optional] 
**LastInstallInfo** | [**ToolsConfigInfoToolsLastInstallInfo**](ToolsConfigInfoToolsLastInstallInfo.md) | Information about the last tools upgrade attempt if applicable.  This information is maintained by the server and is ignored if set by the client.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

