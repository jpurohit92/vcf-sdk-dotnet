# Vcenter.ViJson.OpenApi.Model.DVSFeatureCapability

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NetworkResourceManagementSupported** | **bool** | Deprecated as of vSphere API 5.0, use &lt;code&gt;networkResourceManagementCapability&lt;/code&gt;.*DVSNetworkResourceManagementCapability.networkResourceManagementSupported*.  Indicates whether network I/O control is supported on the vSphere Distributed Switch.  | 
**VmDirectPathGen2Supported** | **bool** | Deprecated as of vSphere API 8.0. VMDirectPath Gen 2 is no longer supported and there is no replacement.  Indicates whether VMDirectPath Gen 2 is supported on the distributed virtual switch.  See *HostCapability*.*HostCapability.vmDirectPathGen2Supported* and *PhysicalNic*.*PhysicalNic.vmDirectPathGen2Supported*.  For a third-party distributed switch implementation, you can specify this property during switch creation or when you call the *DistributedVirtualSwitch.UpdateDvsCapability* method.  VMDirectPath Gen 2 is supported in vSphere Distributed Switch Version 4.1 or later.  | [optional] 
**NicTeamingPolicy** | **List&lt;string&gt;** | The available teaming modes for the vSphere Distributed Switch.  The value can be one or more of *DistributedVirtualSwitchNicTeamingPolicyMode_enum*.  | [optional] 
**NetworkResourcePoolHighShareValue** | **int** | Deprecated as of vSphere API 5.0, use &lt;code&gt;networkResourceManagementCapability&lt;/code&gt;.*DVSNetworkResourceManagementCapability.networkResourcePoolHighShareValue*.  This is the value for *high* in *DVSNetworkResourcePoolAllocationInfo.shares*.  This implicitly defines the legal range of share values to be between 1 and this. This also defines values for other level types, such as *normal* being one half of this value and *low* being one fourth of this value.  | [optional] 
**NetworkResourceManagementCapability** | [**DVSNetworkResourceManagementCapability**](DVSNetworkResourceManagementCapability.md) | Network resource management capabilities supported by a distributed virtual switch.  | [optional] 
**HealthCheckCapability** | [**DVSHealthCheckCapability**](DVSHealthCheckCapability.md) | Health check capabilities supported by a *VmwareDistributedVirtualSwitch*.  | [optional] 
**RollbackCapability** | [**DVSRollbackCapability**](DVSRollbackCapability.md) | Host rollback capability.  If &lt;code&gt;rollbackCapability&lt;/code&gt;.*DVSRollbackCapability.rollbackSupported* is true, network operations that disconnect the the host are rolled back.  | [optional] 
**BackupRestoreCapability** | [**DVSBackupRestoreCapability**](DVSBackupRestoreCapability.md) | Backup, restore, and rollback capabilities.  Backup and restore are supported only for *VmwareDistributedVirtualSwitch*. Rollback is supported for *VmwareDistributedVirtualSwitch* and *DistributedVirtualPortgroup*. For information about backup and restore, see the *DistributedVirtualSwitchManager* methods *DistributedVirtualSwitchManager.DVSManagerExportEntity_Task* and *DistributedVirtualSwitchManager.DVSManagerImportEntity_Task*. For information about rollback, see the *DistributedVirtualSwitch*.*DistributedVirtualSwitch.DVSRollback_Task* and *DistributedVirtualPortgroup*.*DistributedVirtualPortgroup.DVPortgroupRollback_Task* methods.  | [optional] 
**NetworkFilterSupported** | **bool** | Indicates whether Network Filter feature is supported in vSphere Distributed Switch.  | [optional] 
**MacLearningSupported** | **bool** | Indicates whether MAC learning feature is supported in vSphere Distributed Switch.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

