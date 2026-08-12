# Vcenter.ViJson.OpenApi.Model.ReplicationConfigSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Generation** | **long** | A generation number (&amp;gt;&#x3D;0) that reflects the \&quot;freshness\&quot; of the ReplicationConfigSpec on which a re-configuration is based.  The generation number is used to detect and disallow concurrent updates to a VM&#39;s replication settings. For initial replication enablement, generation &#x3D; 0. The replication settings of every replication re-configuration operation must reflect the latest generation number known to the caller. It takes an explicit call to get the latest replication settings to find out what the latest generation number is. The update algorithm of the generation number is opaque to the caller; e.g., the caller cannot assume that the generation numbers are incremented by one every time replication is (re)configured, not even that they are changing monotonically.  | 
**VmReplicationId** | **string** | An opaque identifier that uniquely identifies a replicated VM between primary and secondary sites.  | 
**Destination** | **string** | The IP address of the HBR Server in the secondary site where this VM is replicated to.  Note: If net encryption is enabled, this is the address of the encryption tunnelling agent.  | 
**Port** | **int** | The port on the HBR Server in the secondary site where this VM is replicated to.  Note: If net encryption is enabled, this is the port of the encryption tunneling agent.  | 
**Rpo** | **long** | The Recovery Point Objective specified for this VM, in minutes.  Currently, valid values are in the range of 1 minute to 1440 minutes (24 hours).  | 
**QuiesceGuestEnabled** | **bool** | Flag that indicates whether or not to quiesce the file system or applications in the guest OS before a consistent replica is created.  | 
**Paused** | **bool** | Flag that indicates whether or not the vm or group has been paused for replication.  | 
**OppUpdatesEnabled** | **bool** | Flag that indicates whether or not to perform opportunistic updates in-between consistent replicas.  | 
**NetCompressionEnabled** | **bool** | Flag that indicates whether or not compression should be used when sending traffic over the network.  The primary will negotiate the best compression with the server on the secondary if this is enabled.  | [optional] 
**NetEncryptionEnabled** | **bool** | Flag that indicates whether or not encryption should be used when sending traffic over the network.  The primary will use the remoteCertificateThumbprint to verify the identity of the remote server.  | [optional] 
**EncryptionDestination** | **string** | The IP address of the remote HBR server, target for encrypted LWD.  This field is required when net encryption is enabled, ignored otherwise.  | [optional] 
**AdditionalEncryptionDestination** | **List&lt;string&gt;** | ***Since:*** vSphere API Release 9.1.0.0  | [optional] 
**EncryptionPort** | **int** | The port on the remote HBR server, target for encrypted LWD.  This field is only relevant when net encryption is enabled.  | [optional] 
**RemoteCertificateThumbprint** | **string** | Deprecated field is deprecated, use *HbrManager.HbrConfigureReplicationTargets_Task* instead.  The SHA256 thumbprint of the remote server certificate.  This field is only relevant when net encryption is enabled.  | [optional] 
**DataSetsReplicationEnabled** | **bool** | Flag that indicates whether DataSets files are replicated or not.  ***Since:*** vSphere API Release 8.0.0.0  | [optional] 
**UseHbrProxyHttpPreamble** | **bool** | Flag that indicates whether to use HTTP preamble for HBRProxy when connecting to the remote site.  If unset, defaults to false.  ***Since:*** vSphere API Release 9.1.0.0  | [optional] 
**Disk** | [**List&lt;ReplicationInfoDiskSettings&gt;**](ReplicationInfoDiskSettings.md) | The set of the disks of this VM that are configured for replication.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

