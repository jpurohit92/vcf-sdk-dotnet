# Vcenter.ViJson.OpenApi.Model.VMwareIpfixConfig

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CollectorIpAddress** | **string** | IP address for the ipfix collector, using IPv4 or IPv6.  IPv6 is supported in vSphere Distributed Switch Version 6.0 or later. This must be set before ipfix monitoring can be enabled for the switch, or for any portgroup or port of the switch.  | [optional] 
**CollectorPort** | **int** | Port for the ipfix collector.  This must be set before ipfix monitoring can be enabled for the switch, or for any portgroup or port of the switch. Legal value range is 0-65535.  | [optional] 
**ObservationDomainId** | **long** | Observation Domain Id for the ipfix collector.  Observation Domain Id is supported in vSphere Distributed Switch Version 6.0 or later. Legal value range is 0-((2^32)-1)  | [optional] 
**ActiveFlowTimeout** | **int** | The number of seconds after which \&quot;active\&quot; flows are forced to be exported to the collector.  Legal value range is 60-3600. Default: 60.  | 
**IdleFlowTimeout** | **int** | Deprecated as of vSphere API 9.0 Since from 9.0, client still can set the value of IpfixConfig.idleFlowTimeout when creating/reconfiguring DVS, but no matter what value they set, it will be overridden to 15 by backend. In 9.0, idleFlow still functions with this overridden timeout &#39;15&#39;, but it would be fully replaced by CT-based IPFIX in newer releases.  The number of seconds after which \&quot;idle\&quot; flows are forced to be exported to the collector.  Legal value range is 10-600. Default: 15.  | [optional] 
**SamplingRate** | **int** | The ratio of total number of packets to the number of packets analyzed.  Set to 0 to disable sampling. Legal value range is 0-16384. Default: 4096. Since the 9.1 release, the ipfix sampling rate is no longer supported if NSX is enabled on this DVS host switch on that ESXi host. Any specified value for the sampling rate during DVS creation or reconfiguration will be ignored on ESXi hosts.  | 
**InternalFlowsOnly** | **bool** | Whether to limit analysis to traffic that has both source and destination served by the same host.  Default: false.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

