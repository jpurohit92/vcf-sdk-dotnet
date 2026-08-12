# Vcenter.ViJson.OpenApi.Model.DVSNetworkResourceManagementCapability

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NetworkResourceManagementSupported** | **bool** | Indicates whether network I/O control is supported on the vSphere Distributed Switch.  Network I/O control is supported in vSphere Distributed Switch Version 4.1 or later.  | 
**NetworkResourcePoolHighShareValue** | **int** | High share level (*SharesLevel_enum*.*high*) for *DVSNetworkResourcePoolAllocationInfo*.*DVSNetworkResourcePoolAllocationInfo.shares*.  The &lt;code&gt;networkResourcePoolHighshareValue&lt;/code&gt; property implicitly defines the legal range of share values to be between 1 and this value. This property also defines values for other level types, such as *normal* being one half of this value and *low* being one fourth of this value. This feature is supported in vSphere Distributed Switch Version 4.1 or later.  | 
**QosSupported** | **bool** | Indicates whether Qos Tag(802.1p priority tag)is supported on the vSphere Distributed Switch.  Qos Tag is supported in vSphere Distributed Switch Version 5.0 or later.  | 
**UserDefinedNetworkResourcePoolsSupported** | **bool** | Indicates whether the switch supports creating user defined resource pools.  This feature is supported in vSphere Distributed Switch Version 5.0 or later.  | 
**NetworkResourceControlVersion3Supported** | **bool** | Flag to indicate whether Network Resource Control version 3 is supported.  The API supported by Network Resource Control version 3 include: 1. VM virtual NIC network resource specification    *VirtualEthernetCardResourceAllocation* 2. VM virtual NIC network resource pool specification    *DVSVmVnicNetworkResourcePool* 3. Host infrastructure traffic network resource specification    *DvsHostInfrastructureTrafficResource*     Network Resource Control version 3 is supported for Switch Version 6.0 or later.  | [optional] 
**UserDefinedInfraTrafficPoolSupported** | **bool** | Indicates whether user defined infrastructure traffic pool supported in vSphere Distributed Switch.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

