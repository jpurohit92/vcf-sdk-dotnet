# Vcenter.ViJson.OpenApi.Model.HostPatchManagerStatus

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier for this update.  | 
**Applicable** | **bool** | Whether or not this update is applicable to this host.  An update may not be applicable to the ESX host for many reasons - for example, it is obsolete, it conflicts with other installed patches or libraries, and so on. The *HostPatchManagerStatus.reason* shows some of the reasons why the update is not applicable. An update could be inapplicable with no reason listed. This is because the prerequisite install state is not correct. For example, update A is one of the prerequisites of update B. B not only requires A to be installed, but also requires the host is rebooted after A is installed. When A is installed and the host has not been restarted after the installation, B will not be applicable. In such a case, the scan on both updates A and B would yield a whole picture of the update applicable status.  | 
**Reason** | **List&lt;string&gt;** | Possible reasons why an update is not applicable to the ESX host.  See also *HostPatchManagerReason_enum*.  | [optional] 
**Integrity** | **string** | The integrity status of the update&#39;s metadata.  The value would be unset if the integrity status is unknown to the server.  See also *HostPatchManagerIntegrityStatus_enum*.  | [optional] 
**Installed** | **bool** | Whether the update is installed on the server.  | 
**InstallState** | **List&lt;string&gt;** | The installation state of the update.  Unset if the update is not installed on the server.  See also *HostPatchManagerInstallState_enum*.  | [optional] 
**PrerequisitePatch** | [**List&lt;HostPatchManagerStatusPrerequisitePatch&gt;**](HostPatchManagerStatusPrerequisitePatch.md) | Prerequisite update.  | [optional] 
**RestartRequired** | **bool** | Whether or not this update requires a host restart to take effect.  | 
**ReconnectRequired** | **bool** | Whether or not this update requires caller to reconnect to the host.  This is usually because the update is on the agent that running on the host, the agent would thus be restarted when the update is applied. Caller can reconnect (and possibly relogin) to the host after the agent has been restarted.  | 
**VmOffRequired** | **bool** | Whether or not this update requires the host in maintenance mode.  | 
**SupersededPatchIds** | **List&lt;string&gt;** | Patches that are superseded by this update.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

