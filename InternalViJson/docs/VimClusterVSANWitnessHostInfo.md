# Vcenter.ViJson.OpenApi.Model.VimClusterVSANWitnessHostInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NodeUuid** | **string** | vSAN UUID of witness host  | 
**FaultDomainName** | **string** | User friendly name of Fault Domain, which witness host resides in  | [optional] 
**PreferredFdName** | **string** | User friendly name of preferred Fault Domain configured in witness host.  | [optional] 
**PreferredFdUuid** | **string** | UUID of preferred Fault Domain configured in witness host.  | [optional] 
**UnicastAgentAddr** | **string** | IP address used by witness host, to communicate with data hosts in vSAN stretched cluster.  The IP protocol supports IPv4 and IPv6, and which protocol to take, is determined by concrete vSAN network configurations on all hosts of vSAN stretched cluster. If both protocols are supported by all hosts, IPv4 will be taken. This IP address is from the first discovered virtual adapter of witness host, which enables vSAN traffic and supports taken IP protocol.  | [optional] 
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | ManagedEntity of witness host.  Refers instance of *HostSystem*.  | [optional] 
**MetadataMode** | **bool** | True to indicate the host is a metadata host as opposed to witness host.  Default to False if unset, meaning it is witness host. Metadata host is currently unsupported vSAN feature and it is not used for vSAN stretched cluster.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

