# Vcenter.Automation.OpenApi.Model.VcenterTopologyReplicationStatusFilterSpec
The Vcenter.Topology.ReplicationStatus.FilterSpec schema contains property used to filter the results when listing replication status for the vCenter and Platform Services Controller nodes (see *GET /vcenter/topology/replication-status*) of type VCSA_EMBEDDED/PSC_EXTERNAL (see *Vcenter.Topology.Nodes.Info.type*).  This schema was added in __vSphere API 6.7.2__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Nodes** | **List&lt;string&gt;** | Identifier that a vCenter and Platform Services Controller node must have to match the filter. (see *Vcenter.Topology.ReplicationStatus.Summary.node*).  This property was added in __vSphere API 6.7.2__.  If missing or &#x60;null&#x60; or empty, all vCenter and Platform Services Controller nodes of type VCSA_EMBEDDED/PSC_EXTERNAL match the filter.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;com.vmware.vcenter.VCenter.name&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;com.vmware.vcenter.VCenter.name&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

