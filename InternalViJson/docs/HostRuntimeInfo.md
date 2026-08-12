# Vcenter.ViJson.OpenApi.Model.HostRuntimeInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConnectionState** | **HostSystemConnectionStateEnum** | The host connection state.  See the description in the enums for the *ConnectionState* data object type.  | 
**PowerState** | **HostSystemPowerStateEnum** | The host power state.  See the description in the enums for the *PowerState* data object type.  | 
**StandbyMode** | **string** | The host&#39;s standby mode.  For valid values see *HostStandbyMode_enum*. The property is only populated by vCenter server. If queried directly from a ESX host, the property is is unset.  | [optional] 
**InMaintenanceMode** | **bool** | The flag to indicate whether or not the host is in maintenance mode.  This flag is set when the host has entered the maintenance mode. It is not set during the entering phase of maintenance mode.  See also *HostSystem.EnterMaintenanceMode_Task*, *HostSystem.ExitMaintenanceMode_Task*.  | 
**InQuarantineMode** | **bool** | The flag to indicate whether or not the host is in quarantine mode.  InfraUpdateHa will recommend to set this flag based on the HealthUpdates received by the HealthUpdateProviders configured for the cluster. A host that is reported as degraded will be recommended to enter quarantine mode, while a host that is reported as healthy will be recommended to exit quarantine mode. Execution of these recommended actions will set this flag. Hosts in quarantine mode will be avoided by vSphere DRS as long as the increased consolidation in the cluster does not negatively affect VM performance.  See also *HealthUpdateManager*, *ClusterInfraUpdateHaConfigInfo*, *ClusterHostInfraUpdateHaModeAction*.  | [optional] 
**BootTime** | **DateTime** | The time when the host was booted.  | [optional] 
**HealthSystemRuntime** | [**HealthSystemRuntime**](HealthSystemRuntime.md) | Available system health status  | [optional] 
**DasHostState** | [**ClusterDasFdmHostState**](ClusterDasFdmHostState.md) | The availability state of an active host in a vSphere HA enabled cluster.  A host is inactive if it is in maintenance or standby mode, or it has been disconnected from vCenter Server. The active hosts in a cluster form a vSphere HA fault domain.  The property is unset if vSphere HA is disabled, the host is in maintenance or standby mode, or the host is disconnected from vCenter Server. The property is set to hostDown if the host has crashed.  | [optional] 
**TpmPcrValues** | [**List&lt;HostTpmDigestInfo&gt;**](HostTpmDigestInfo.md) | Deprecated as of @released(\&quot;5.1\&quot;) this information should be considered to be neither complete nor reliable.  The array of PCR digest values stored in the TPM device since the last host boot time.  | [optional] 
**VsanRuntimeInfo** | [**VsanHostRuntimeInfo**](VsanHostRuntimeInfo.md) | Host Runtime information related to the VSAN service.  See also *VsanHostRuntimeInfo*.  | [optional] 
**NetworkRuntimeInfo** | [**HostRuntimeInfoNetworkRuntimeInfo**](HostRuntimeInfoNetworkRuntimeInfo.md) | This property is for getting network related runtime info  | [optional] 
**VFlashResourceRuntimeInfo** | [**HostVFlashManagerVFlashResourceRunTimeInfo**](HostVFlashManagerVFlashResourceRunTimeInfo.md) | Runtime information of vFlash resource of the host.  | [optional] 
**HostMaxVirtualDiskCapacity** | **long** | The maximum theoretical virtual disk capacity supported by this host  | [optional] 
**CryptoState** | **string** | Encryption state of the host.  Valid values are enumerated by the *CryptoState* type.  | [optional] 
**CryptoKeyId** | [**CryptoKeyId**](CryptoKeyId.md) | Crypto Key used for coredump encryption  | [optional] 
**StatelessNvdsMigrationReady** | **string** | Indicating the host is ready for NVDS to VDS migration.  See *HostRuntimeInfoStatelessNvdsMigrationState_enum* for supported values.  ***Since:*** vSphere API Release 7.0.2.0  | [optional] 
**PartialMaintenanceMode** | [**List&lt;HostPartialMaintenanceModeRuntimeInfo&gt;**](HostPartialMaintenanceModeRuntimeInfo.md) | The following list contains the runtime status for all the partial maintenance modes currently supported on the host.  ***Since:*** vSphere API Release 8.0.3.0  | [optional] 
**StateEncryption** | [**HostRuntimeInfoStateEncryptionInfo**](HostRuntimeInfoStateEncryptionInfo.md) | Host persistent state encryption information.  ***Since:*** vSphere API Release 7.0.3.0  | [optional] 
**PodVMInfo** | [**PodVMInfo**](PodVMInfo.md) | PodVM related information for a host.  ***Since:*** vSphere API Release 9.1.0.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

