# Vcenter.ViJson.OpenApi.Model.VsanFileServiceIpConfig

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Dhcp** | **bool** | The flag to indicate whether or not DHCP (dynamic host control protocol) is enabled.  If this property is set to true, the ipAddress and the subnetMask strings cannot be set explicitly.  | 
**IpAddress** | **string** | The IP address currently used by the network adapter.  All IP addresses are specified using IPv4 dot notation. For example, \&quot;192.168.0.1\&quot;. Subnet addresses and netmasks are specified using the same notation.  **Note**: When DHCP is enabled, this property reflects the current IP configuration and cannot be set. When DHCP is not enabled, this property can be set explicitly.  | [optional] 
**SubnetMask** | **string** | The subnet mask.  **Note**: When DHCP is not enabled, this property can be set explicitly. When DHCP is enabled, this property reflects the current IP configuration and cannot be set.  | [optional] 
**IpV6Config** | [**HostIpConfigIpV6AddressConfiguration**](HostIpConfigIpV6AddressConfiguration.md) | The ipv6 configuration  | [optional] 
**Fqdn** | **string** | The Full Qualified Domain name (FQDN) to be used with IP addresses for the vSAN File Service instance.  Usually it takes the form of &#39;fs1.example.com&#39;. Please note prior mapping of IP address and FQDN is necessary before configuring vSAN File Service. This may need to update your DNS records. The first component of FQDN is used as netbios name for file service instances, so it must be maximum 15 characters in length.  | [optional] 
**IsPrimary** | **bool** | Whether the IP address is served as the primary IP address for the file service.  The file server running with the primary IP will serve as the NFS referral server which may point to the file shares served by other file servers in this cluster. Only one primary IP address is supported in one domain. Default to False.  | [optional] 
**Gateway** | **string** | The default IPv4 gateway address for the file service access point.  The gateway IP must be the same for all the file servers in this domain.  | 
**AffinityLocation** | **string** | The affinity location for the file server.  This option is only valid under the stretched cluster setup. If this field is specified, this file service instance will be located in the affinity site when it is available. This file server will failover to the other site when its affinity site is down but will fail back once it is available. If this is a non-stretched cluster, this affinity location will not take effect.  See also *VsanSiteLocationType_enum*.  | [optional] 
**Ipv6Gateway** | **string** | The default IPv6 gateway address for the file service access point.  The gateway IP must be the same for all the file servers in this domain.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

