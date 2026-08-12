# Vcenter.ViJson.OpenApi.Model.HostNumaNode

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TypeId** | **int** | Zero-based NUMA ID for the node.  | 
**CpuID** | **List&lt;int&gt;** | Information about each of the CPUs associated with the node.  | 
**MemorySize** | **long** | The total amount of memory in this NUMA node, in bytes.  ***Since:*** vSphere API Release 8.0.0.0  | [optional] 
**MemoryRangeBegin** | **long** | Deprecated as of vSphere 8.0, this property is always set to zero. The memory of a NUMA node is not necessarily a single physically contiguous range.  Beginning memory range for this NUMA node.  | 
**MemoryRangeLength** | **long** | Deprecated as of vSphere 8.0, this property is replaced by *HostNumaNode.memorySize* and is set to the same value. The memory of a NUMA node is not necessarily a single physically contiguous range.  Length of the memory range for this node in bytes, that is, the amount of memory on the node.  | 
**PciId** | **List&lt;string&gt;** | Information about each of the pci devices associated with the node.  The string is of SBDF format, \&quot;Segment:Bus:Device.Function\&quot;.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

