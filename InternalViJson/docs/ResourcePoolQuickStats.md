# Vcenter.ViJson.OpenApi.Model.ResourcePoolQuickStats

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OverallCpuUsage** | **long** | Basic CPU performance statistics, in MHz.  | [optional] 
**OverallCpuDemand** | **long** | Basic CPU performance statistics, in MHz.  | [optional] 
**GuestMemoryUsage** | **long** | Guest memory utilization statistics, in MB.  This is also known as active guest memory. The number can be between 0 and the configured memory size of a virtual machine.  | [optional] 
**HostMemoryUsage** | **long** | Host memory utilization statistics, in MB.  This is also known as consumed host memory. This is between 0 and the configured resource limit. Valid while a virtual machine is running. This includes the overhead memory of a virtual machine.  | [optional] 
**DistributedCpuEntitlement** | **long** | This is the amount of CPU resource, in MHz, that this VM is entitled to, as calculated by DRS.  Valid only for a VM managed by DRS.  | [optional] 
**DistributedMemoryEntitlement** | **long** | This is the amount of memory, in MB, that this VM is entitled to, as calculated by DRS.  Valid only for a VM managed by DRS.  | [optional] 
**StaticCpuEntitlement** | **int** | The static CPU resource entitlement for a virtual machine.  This value is calculated based on this virtual machine&#39;s resource reservations, shares and limit, and doesn&#39;t take into account current usage. This is the worst case CPU allocation for this virtual machine, that is, the amount of CPU resource this virtual machine would receive if all virtual machines running in the cluster went to maximum consumption. Units are MHz.  | [optional] 
**StaticMemoryEntitlement** | **int** | The static memory resource entitlement for a virtual machine.  This value is calculated based on this virtual machine&#39;s resource reservations, shares and limit, and doesn&#39;t take into account current usage. This is the worst case memory allocation for this virtual machine, that is, the amount of memory this virtual machine would receive if all virtual machines running in the cluster went to maximum consumption. Units are MB.  | [optional] 
**PrivateMemory** | **long** | The portion of memory, in MB, that is granted to a virtual machine from non-shared host memory.  | [optional] 
**SharedMemory** | **long** | The portion of memory, in MB, that is granted to a virtual machine from host memory that is shared between VMs.  | [optional] 
**SwappedMemory** | **long** | The portion of memory, in MB, that is granted to a virtual machine from the host&#39;s swap space.  This is a sign that there is memory pressure on the host.  | [optional] 
**BalloonedMemory** | **long** | The size of the balloon driver in a virtual machine, in MB.  The host will inflate the balloon driver to reclaim physical memory from a virtual machine. This is a sign that there is memory pressure on the host.  | [optional] 
**OverheadMemory** | **long** | The amount of memory resource (in MB) that will be used by a virtual machine above its guest memory requirements.  This value is set if and only if a virtual machine is registered on a host that supports memory resource allocation features. For powered off VMs, this is the minimum overhead required to power on the VM on the registered host. For powered on VMs, this is the current overhead reservation, a value which is almost always larger than the minimum overhead, and which grows with time.  See also *HostSystem.QueryMemoryOverheadEx*.  | [optional] 
**ConsumedOverheadMemory** | **long** | The amount of overhead memory, in MB, currently being consumed to run a VM.  This value is limited by the overhead memory reservation for a VM, stored in *ResourcePoolQuickStats.overheadMemory*.  | [optional] 
**CompressedMemory** | **long** | The amount of compressed memory currently consumed by VM, in KB.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

