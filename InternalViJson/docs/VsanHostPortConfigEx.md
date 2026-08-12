# Vcenter.ViJson.OpenApi.Model.VsanHostPortConfigEx

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IpConfig** | [**VsanHostIpConfig**](VsanHostIpConfig.md) | Deprecated as of vSphere API 9.1, vSAN has been using unicast only configuration in all supported releases. The multicast configuration has been deprecated.  *VsanHostIpConfig* for this PortConfig.  | [optional] 
**Device** | **string** | Device name which identifies the network adapter for this PortConfig.  See also *HostVirtualNic.device*.  | 
**TrafficTypes** | **List&lt;string&gt;** | Type of vSAN traffic through this network adapter.  If this field is not set or set empty during Virtual update, type &#39;vsan&#39; will be taken as default. This field is invisible to older version client.  See also *VimVsanHostTrafficType_enum*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

