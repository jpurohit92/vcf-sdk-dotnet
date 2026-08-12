# Vcenter.ViJson.OpenApi.Model.HostNatServiceNameServiceSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DnsAutoDetect** | **bool** | The flag to indicate whether or not the DNS server should be automatically detected or specified explicitly.  | 
**DnsPolicy** | **string** | The policy to use when multiple DNS addresses are available on the host.  | 
**DnsRetries** | **int** | The number of retries before giving up on a DNS request from a virtual network.  | 
**DnsTimeout** | **int** | The time (in seconds) before retrying a DNS request to an external network.  | 
**DnsNameServer** | **List&lt;string&gt;** | The list of DNS servers.  | [optional] 
**NbdsTimeout** | **int** | The time (in seconds) allotted for queries to the NetBIOS Datagram Server (NBDS).  | 
**NbnsRetries** | **int** | Number of retries for each query to the NBNS.  | 
**NbnsTimeout** | **int** | The time (in seconds) allotted for queries to the NBNS.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

