# Vcenter.ViJson.OpenApi.Model.HostConnectInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ServerIp** | **string** | The IP address of the VirtualCenter already managing this host, if any.  | [optional] 
**InDasCluster** | **bool** | If the host is already being managed by a vCenter Server, this property reports true if the host is also part of a vSphere HA enabled cluster.  If this is the case, remove or disconnect the host from this cluster before adding it to another vCenter Server.  | [optional] 
**Host** | [**HostListSummary**](HostListSummary.md) | Summary information about the host.  The status fields and managed object reference is not set when an object of this type is created. These fields and references are typically set later when these objects are associated with a host.  | 
**Vm** | [**List&lt;VirtualMachineSummary&gt;**](VirtualMachineSummary.md) | The list of virtual machines on the host.  | [optional] 
**VimAccountNameRequired** | **bool** | Whether or not the host requires a vimAccountName and password to be set in the ConnectSpec.  This is normally only required for VMware Server hosts.  | [optional] 
**ClusterSupported** | **bool** | Whether or not the host supports clustering capabilities such as HA or DRS and therefore can be added to a cluster.  If false, the host must be added as a standalone host.  | [optional] 
**Network** | [**List&lt;HostConnectInfoNetworkInfo&gt;**](HostConnectInfoNetworkInfo.md) | The list of network information for networks configured on this host.  | [optional] 
**Datastore** | [**List&lt;HostDatastoreConnectInfo&gt;**](HostDatastoreConnectInfo.md) | The list of datastores on the host.  | [optional] 
**License** | [**HostLicenseConnectInfo**](HostLicenseConnectInfo.md) | License manager information on the host  | [optional] 
**Capability** | [**HostCapability**](HostCapability.md) | Host capabilities.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

