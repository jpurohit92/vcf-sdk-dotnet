# Vcenter.ViJson.OpenApi.Model.VirtualMachineQuickStats

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OverallCpuUsage** | **int** | Basic CPU performance statistics, in MHz.  Valid while the virtual machine is running.  | [optional] 
**OverallCpuDemand** | **int** | Basic CPU performance statistics, in MHz.  Valid while the virtual machine is running.  | [optional] 
**OverallCpuReadiness** | **int** | Percentage of time that the virtual machine was ready, but could not get scheduled to run on the physical CPU.  Valid while the virtual machine is running.  | [optional] 
**GuestMemoryUsage** | **int** | Guest memory utilization statistics, in MB.  This is also known as active guest memory. The number can be between 0 and the configured memory size of the virtual machine. Valid while the virtual machine is running.  | [optional] 
**HostMemoryUsage** | **int** | Host memory utilization statistics, in MB.  This is also known as consumed host memory. This is between 0 and the configured resource limit. Valid while the virtual machine is running. This includes the overhead memory of the VM.  | [optional] 
**GuestHeartbeatStatus** | **ManagedEntityStatusEnum** | Guest operating system heartbeat metric.  See *VirtualMachine.guestHeartbeatStatus* for a description.  | 
**DistributedCpuEntitlement** | **int** | This is the amount of CPU resource, in MHz, that this VM is entitled to, as calculated by DRS.  Valid only for a VM managed by DRS.  | [optional] 
**DistributedMemoryEntitlement** | **int** | This is the amount of memory, in MB, that this VM is entitled to, as calculated by DRS.  Valid only for a VM managed by DRS.  | [optional] 
**StaticCpuEntitlement** | **int** | The static CPU resource entitlement for a virtual machine.  This value is calculated based on this virtual machine&#39;s resource reservations, shares and limit, and doesn&#39;t take into account current usage. This is the worst case CPU allocation for this virtual machine, that is, the amount of CPU resource this virtual machine would receive if all virtual machines running in the cluster went to maximum consumption. Units are MHz.  | [optional] 
**StaticMemoryEntitlement** | **int** | The static memory resource entitlement for a virtual machine.  This value is calculated based on this virtual machine&#39;s resource reservations, shares and limit, and doesn&#39;t take into account current usage. This is the worst case memory allocation for this virtual machine, that is, the amount of memory this virtual machine would receive if all virtual machines running in the cluster went to maximum consumption. Units are MB.  | [optional] 
**GrantedMemory** | **int** | Amount of host physical memory that is mapped for a virtual machine, in MB.  The number can be between 0 and the configured memory size of the virtual machine. Valid while the virtual machine is running.  | [optional] 
**PrivateMemory** | **int** | The portion of memory, in MB, that is granted to this VM from non-shared host memory.  | [optional] 
**SharedMemory** | **int** | The portion of memory, in MB, that is granted to this VM from host memory that is shared between VMs.  | [optional] 
**SwappedMemory** | **int** | The portion of memory, in MB, that is granted to this VM from the host&#39;s swap space.  This is a sign that there is memory pressure on the host.  | [optional] 
**BalloonedMemory** | **int** | The size of the balloon driver in the VM, in MB.  The host will inflate the balloon driver to reclaim physical memory from the VM. This is a sign that there is memory pressure on the host.  | [optional] 
**ConsumedOverheadMemory** | **int** | The amount of consumed overhead memory, in MB, for this VM.  | [optional] 
**FtLogBandwidth** | **int** | The network bandwidth used for logging between the primary and secondary fault tolerance VMs.  The unit is kilobytes per second.  | [optional] 
**FtSecondaryLatency** | **int** | The amount of time in wallclock that the VCPU of the secondary fault tolerance VM is behind the VCPU of the primary VM.  The unit is millisecond.  | [optional] 
**FtLatencyStatus** | **ManagedEntityStatusEnum** | The latency status of the fault tolerance VM.  ftLatencyStatus is determined by the value of ftSecondaryLatency. ftLatencyStatus is: green, if ftSecondaryLatency is less than or equal to 2 seconds; yellow, if ftSecondaryLatency is greater than 2 seconds, and less than or equal to 6 seconds; red, if ftSecondaryLatency is greater than 6 seconds; gray, if ftSecondaryLatency is unknown.  | [optional] 
**CompressedMemory** | **long** | The amount of compressed memory currently consumed by VM, in Kb.  | [optional] 
**UptimeSeconds** | **int** | The system uptime of the VM in seconds.  | [optional] 
**SsdSwappedMemory** | **long** | The amount of memory swapped to fast disk device such as SSD, in KB.  | [optional] 
**ActiveMemory** | **int** | The amount of memory that was recently touched by the VM, in MB.  ***Since:*** vSphere API Release 7.0.3.0  | [optional] 
**MemoryTierStats** | [**List&lt;VirtualMachineQuickStatsMemoryTierStats&gt;**](VirtualMachineQuickStatsMemoryTierStats.md) | Stats for each physical memory tier.  A physical memory tier consists of one or more logical memory tiers of the same *HostMemoryTierType_enum*. For example, the logical tiers can be tier0 (DRAM), tier1 (DRAM), and tier2 (PMEM), while the physical tiers are just DRAM and PMEM.  ***Since:*** vSphere API Release 7.0.3.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

