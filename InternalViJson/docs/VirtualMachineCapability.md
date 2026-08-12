# Vcenter.ViJson.OpenApi.Model.VirtualMachineCapability

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SnapshotOperationsSupported** | **bool** | Indicates whether or not a virtual machine supports snapshot operations.  | 
**MultipleSnapshotsSupported** | **bool** | Indicates whether or not a virtual machine supports multiple snapshots.  This value is not set when the virtual machine is unavailable, for instance, when it is being created or deleted.  | 
**SnapshotConfigSupported** | **bool** | Indicates whether or not a virtual machine supports snapshot config.  | 
**PoweredOffSnapshotsSupported** | **bool** | Indicates whether or not a virtual machine supports snapshot operations in poweredOff state.  This flag doesn&#39;t affect vim.VirtualMachine.GetSnapshot, which is always supported.  | 
**MemorySnapshotsSupported** | **bool** | Indicates whether or not a virtual machine supports memory snapshots.  | 
**RevertToSnapshotSupported** | **bool** | Indicates whether or not a virtual machine supports reverting to a snapshot.  | 
**QuiescedSnapshotsSupported** | **bool** | Indicates whether or not a virtual machine supports quiesced snapshots.  | 
**DisableSnapshotsSupported** | **bool** | Deprecated as of vSphere API 4.0. The value returned from the server is always false.  Indicates whether or not snapshots can be disabled.  | 
**LockSnapshotsSupported** | **bool** | Indicates whether or not the snapshot tree can be locked.  | 
**ConsolePreferencesSupported** | **bool** | Indicates whether console preferences can be set for this virtual machine.  | 
**CpuFeatureMaskSupported** | **bool** | Indicates whether CPU feature requirements masks can be set for this virtual machine.  Masking for hardware version 9 and newer virtual machines is controlled by *VirtualMachineCapability.featureRequirementSupported*.  | 
**S1AcpiManagementSupported** | **bool** | Indicates whether or not a virtual machine supports ACPI S1 settings management.  | 
**SettingScreenResolutionSupported** | **bool** | Indicates whether of not this virtual machine supports setting the screen resolution of the console window.  This capability depends on the guest operating system configured for this virtual machine.  | 
**ToolsAutoUpdateSupported** | **bool** | Supports tools auto-update.  | 
**VmNpivWwnSupported** | **bool** | Supports virtual machine NPIV WWN.  | 
**NpivWwnOnNonRdmVmSupported** | **bool** | Supports assigning NPIV WWN to virtual machines that don&#39;t have RDM disks.  | 
**VmNpivWwnDisableSupported** | **bool** | Indicates whether the NPIV disabling operation is supported the virtual machine.  | 
**VmNpivWwnUpdateSupported** | **bool** | Indicates whether the update of NPIV WWNs are supported on the virtual machine.  | 
**SwapPlacementSupported** | **bool** | Flag indicating whether the virtual machine has a configurable *swapfile placement policy*.  | 
**ToolsSyncTimeSupported** | **bool** | Indicates whether asking tools to sync time with the host is supported.  | 
**VirtualMmuUsageSupported** | **bool** | Indicates whether or not the use of nested page table hardware support can be explicitly set.  | 
**DiskSharesSupported** | **bool** | Indicates whether resource settings for disks can be applied to this virtual machine.  | 
**BootOptionsSupported** | **bool** | Indicates whether boot options can be configured for this virtual machine.  | 
**BootRetryOptionsSupported** | **bool** | Indicates whether automatic boot retry can be configured for this virtual machine.  | 
**SettingVideoRamSizeSupported** | **bool** | Flag indicating whether the video ram size of this virtual machine can be configured.  | 
**SettingDisplayTopologySupported** | **bool** | Indicates whether of not this virtual machine supports setting the display topology of the console window.  This capability depends on the guest operating system configured for this virtual machine.  | 
**RecordReplaySupported** | **bool** | Deprecated as of vSphere API 6.0.  Indicates whether record and replay functionality is supported on this virtual machine.  | 
**ChangeTrackingSupported** | **bool** | Indicates that change tracking is supported for virtual disks of this virtual machine.  However, even if change tracking is supported, it might not be available for all disks of the virtual machine. For example, passthru raw disk mappings or disks backed by any Ver1BackingInfo cannot be tracked.  | 
**MultipleCoresPerSocketSupported** | **bool** | Indicates whether multiple virtual cores per socket is supported on this VM.  | 
**HostBasedReplicationSupported** | **bool** | Indicates that host based replication is supported on this virtual machine.  However, even if host based replication is supported, it might not be available for all disk types. For example, passthru raw disk mappings can not be replicated.  | 
**GuestAutoLockSupported** | **bool** | Indicates whether features like guest OS auto-lock and MKS connection controls are supported for this virtual machine.  | 
**MemoryReservationLockSupported** | **bool** | Indicates whether *memoryReservationLockedToMax* may be set to true for this virtual machine.  | 
**FeatureRequirementSupported** | **bool** | Indicates whether featureRequirement feature is supported.  | 
**PoweredOnMonitorTypeChangeSupported** | **bool** | Indicates whether a monitor type change is supported while this virtual machine is in the poweredOn state.  | 
**SeSparseDiskSupported** | **bool** | Indicates whether this virtual machine supports the Flex-SE (space-efficient, sparse) format for virtual disks.  | 
**NestedHVSupported** | **bool** | Indicates whether this virtual machine supports nested hardware-assisted virtualization.  | 
**VPMCSupported** | **bool** | Indicates whether this virtual machine supports virtualized CPU performance counters.  | 
**SecureBootSupported** | **bool** | Indicates whether secureBoot is supported for this virtual machine.  | [optional] 
**PerVmEvcSupported** | **bool** | Indicates whether this virtual machine supports Per-VM EVC mode.  | [optional] 
**VirtualMmuUsageIgnored** | **bool** | Indicates that *VirtualMachineFlagInfo.virtualMmuUsage* is ignored by this virtual machine, always operating as if \&quot;on\&quot; was selected.  | [optional] 
**VirtualExecUsageIgnored** | **bool** | Indicates that *VirtualMachineFlagInfo.virtualExecUsage* is ignored by this virtual machine, always operating as if \&quot;hvOn\&quot; was selected.  | [optional] 
**DiskOnlySnapshotOnSuspendedVMSupported** | **bool** | Indicates whether this virtual machine supports creating disk-only snapshots in suspended state.  If this capability is not set, the snapshot of a virtual machine in suspended state will always include memory.  | [optional] 
**SuspendToMemorySupported** | **bool** | Indicates whether this virtual machine supports suspending to memory.  ***Since:*** vSphere API Release 7.0.2.0  | [optional] 
**ToolsSyncTimeAllowSupported** | **bool** | Indicates support for allowing or disallowing all tools time sync with host.  ***Since:*** vSphere API Release 7.0.1.0  | [optional] 
**SevSupported** | **bool** | Indicates support for AMD-SEV (Secure Encrypted Virtualization).  SEV is supported when set to true, and unsupported otherwise.  ***Since:*** vSphere API Release 7.0.1.0  | [optional] 
**PmemFailoverSupported** | **bool** | Deprecated as of vSphere 9.0 APIs with no replacement.  Indicates support for failover to a different host on VM&#39;s with pmem.  Failover is supported when set to true, and unsupported otherwise.  ***Since:*** vSphere API Release 7.0.2.0  | [optional] 
**RequireSgxAttestationSupported** | **bool** | Whether the VM supports requiring SGX remote attestation.  ***Since:*** vSphere API Release 8.0.0.1  | [optional] 
**ChangeModeDisksSupported** | **bool** | Indicates support for change mode on virtual disks  ***Since:*** vSphere API Release 8.0.0.1  | [optional] 
**VendorDeviceGroupSupported** | **bool** | Indicates support for Vendor Device Groups  ***Since:*** vSphere API Release 8.0.1.0  | [optional] 
**SevSnpSupported** | **bool** | Indicates support for AMD-SEV-SNP (Secure Encrypted Virtualization Secure Nested Paging).  SEV-SNP is supported when set to true, and unsupported otherwise.  ***Since:*** vSphere API Release 9.0.0.0  | [optional] 
**TdxSupported** | **bool** | Indicates support for INTEL-TDX (Trusted Domain Extensions).  TDX is supported when set to true, and unsupported otherwise.  ***Since:*** vSphere API Release 9.0.0.0  | [optional] 
**EhvSecureBootSupported** | **bool** | Indicates support for UEFI Secure Boot in EHV VMs.  It is supported when set to true, and unsupported otherwise.  ***Since:*** vSphere API Release 9.1.0.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

