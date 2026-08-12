# Vcenter.Automation.OpenApi.Model.VcenterTopologyReplicationStatusSummary
The Vcenter.Topology.ReplicationStatus.Summary schema contains replication information of partner vCenter or Platform Services Controller node of type VCSA_EMBEDDED/PSC_EXTERNAL (see *Vcenter.Topology.Nodes.Info.type*).  This schema was added in __vSphere API 6.7.2__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Node** | **string** | Identifier for the vCenter or Platform Services Controller node. Identifier can be either IP address or DNS resolvable name of the node.  This property was added in __vSphere API 6.7.2__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.VCenter.name&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.VCenter.name&#x60;. | 
**ReplicationPartner** | **string** | Identifier for the vCenter or Platform Services Controller replication partner. Identifier can be either IP address or DNS resolvable name of the replication partner.  This property was added in __vSphere API 6.7.2__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.VCenter.name&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.VCenter.name&#x60;. | 
**PartnerAvailable** | **bool** | Indicates if the VMware Directory Service on partner is reachable or not.  This property was added in __vSphere API 6.7.2__. | 
**StatusAvailable** | **bool** | Indicates if the replication status for the node with respect to replication partner can be retrieved or not.  This property was added in __vSphere API 6.7.2__. | 
**Replicating** | **bool** | Indicates if node is processing replication changes from the replication partner.  This property was added in __vSphere API 6.7.2__.  This property will be missing or &#x60;null&#x60; if the partner host or replication status is not available, i.e, if *Vcenter.Topology.ReplicationStatus.Summary.partner_available* or *Vcenter.Topology.ReplicationStatus.Summary.status_available* is false. | [optional] 
**ChangeLag** | **long** | Number of replication changes node is behind the replication partner.  This property was added in __vSphere API 6.7.2__.  This property will be missing or &#x60;null&#x60; if the partner host or replication status is not available, i.e, if *Vcenter.Topology.ReplicationStatus.Summary.partner_available* or *Vcenter.Topology.ReplicationStatus.Summary.status_available* is false. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

