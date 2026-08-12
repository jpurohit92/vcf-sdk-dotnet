# Vcenter.ViJson.OpenApi.Model.GuestStackInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DnsConfig** | [**NetDnsConfigInfo**](NetDnsConfigInfo.md) | Client DNS configuration.  How DNS queries are resolved.  | [optional] 
**IpRouteConfig** | [**NetIpRouteConfigInfo**](NetIpRouteConfigInfo.md) | IP route table configuration.  | [optional] 
**IpStackConfig** | [**List&lt;KeyValue&gt;**](KeyValue.md) | Report Kernel IP configuration settings.  The key part contains a unique number in the report. The value part contains the &#39;key&#x3D;value&#39; as provided by the underlying provider. For example on Linux, BSD, the systcl -a output would be reported as: key&#x3D;&#39;5&#39;, value&#x3D;&#39;net.ipv4.tcp\\_keepalive\\_time &#x3D; 7200&#39;  | [optional] 
**DhcpConfig** | [**NetDhcpConfigInfo**](NetDhcpConfigInfo.md) | Client side DHCP for a given interface.  This reports only the system wide dhcp client settings. See NicInfo.IpConfig for per interface settings. For example on Linux, BSD systems: Using the file dhclient.conf output would be reported as: key&#x3D;&#39;1&#39;, value&#x3D;&#39;timeout 60;&#39; key&#x3D;&#39;2&#39;, value&#x3D;&#39;reboot 10;&#39;  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

