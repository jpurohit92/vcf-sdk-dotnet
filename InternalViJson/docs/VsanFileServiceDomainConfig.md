# Vcenter.ViJson.OpenApi.Model.VsanFileServiceDomainConfig

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The vSAN File Service domain name should be unique within a vSAN cluster, Any valid unique identifier can be used as name.  No white spaces and special characters(except \\_ - .) with length of the domain name limited to 80 char. It is not necessary to associate this domain with any Directory Service (AD domain). This field is required for domain creation.  | [optional] 
**DnsServerAddresses** | **List&lt;string&gt;** | The IP address of DNS server address, which is used to resolve the hostnames within the DNS domain.  Providing this parameter is a must for file service domain creation operation.  | [optional] 
**DnsSuffixes** | **List&lt;string&gt;** | The list of DNS suffixes which can be resolved by the DNS servers.  An exhaustive list of all DNS domains and subdomains from where clients can access the file shares must be provided. Providing this parameter is a must for file service domain creation operation.  | [optional] 
**FileServerIpConfig** | [**List&lt;VsanFileServiceIpConfig&gt;**](VsanFileServiceIpConfig.md) | Define a pool of IP addresses that will be used by vSAN File Service to provide file access from multiple file server.  Each file server will be bound to one of the IP configurations in the IP pool and serve the NFS requests. A minimum of one such address is needed, more may be required based on load and number of shares. To evenly spread the workload, it is recommended to have equal (or greater) number of IP addresses than the number of hosts in the cluster. All the IP address will be required to be on the same subnet. One primary IP must be specified for the NFS referral server. All the file shares on vSAN file service can be listed and accessed with this primary IP. When a referral is encountered, the NFS client will automatically receive the actual managing file server location from referral server with the primary IP. This field is required for domain creation.  | [optional] 
**DirectoryServerConfig** | [**VsanDirectoryServerConfig**](VsanDirectoryServerConfig.md) | The directory server integrated with for the domain.  If Directory server configuration is provided NFS shares can be configured with KRB5 authentication, otherwise only AUTH\\_SYS(sys or unmanaged client) configs are allowed.  | [optional] 
**VarVersion** | **string** | The domain config version.  It is recommended to leave this field unset to let the domain configuration negotiated between the vCenter and ESXi.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

