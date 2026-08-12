# Vcenter.ViJson.OpenApi.Model.DVPortSetting

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Blocked** | [**BoolPolicy**](BoolPolicy.md) | Indicates whether this port is blocked.  If a port is blocked, packet forwarding is stopped.  | [optional] 
**VmDirectPathGen2Allowed** | [**BoolPolicy**](BoolPolicy.md) | Deprecated as of vSphere API 8.0. VMDirectPath Gen 2 is no longer supported and there is no replacement.  Indicates whether this port is allowed to do VMDirectPath Gen2 network passthrough.  Direct path capability is defined at host, switch, and device levels. See the &lt;code&gt;vmDirectPathGen2Supported&lt;/code&gt; properties on the *DVSFeatureCapability*, *HostCapability*, *PhysicalNic*, and *VirtualEthernetCardOption* objects.  | [optional] 
**InShapingPolicy** | [**DVSTrafficShapingPolicy**](DVSTrafficShapingPolicy.md) | Network shaping policy for controlling throughput of inbound traffic.  | [optional] 
**OutShapingPolicy** | [**DVSTrafficShapingPolicy**](DVSTrafficShapingPolicy.md) | Network shaping policy for controlling throughput of outbound traffic.  | [optional] 
**VendorSpecificConfig** | [**DVSVendorSpecificConfig**](DVSVendorSpecificConfig.md) | Opaque binary blob that stores vendor specific configuration.  | [optional] 
**NetworkResourcePoolKey** | [**StringPolicy**](StringPolicy.md) | Deprecated as of vSphere API 6.0 Use *DVPortgroupConfigInfo.vmVnicNetworkResourcePoolKey* instead to reference the virtual NIC network resource pool.  The key of user defined network resource pool to be associated with a port.  The default value for this property is \&quot;-1\&quot;, indicating that this port is not associated with any network resource pool.  | [optional] 
**FilterPolicy** | [**DvsFilterPolicy**](DvsFilterPolicy.md) | Configuration for Network Filter Policy.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

