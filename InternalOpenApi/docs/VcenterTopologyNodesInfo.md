# Vcenter.Automation.OpenApi.Model.VcenterTopologyNodesInfo
The Vcenter.Topology.Nodes.Info schema contains vCenter or Platform Services Controller node details.  This schema was added in __vSphere API 6.7.2__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Domain** | **string** | Domain name of the node.  This property was added in __vSphere API 6.7.2__. | 
**Type** | **string** | Appliance type of the node.  Possible values:   - &#x60;VCSA_EMBEDDED&#x60;: vCenter Server Appliance with an embedded Platform Services Controller.   - &#x60;VCSA_EXTERNAL&#x60;: vCenter Server Appliance with an external Platform Services Controller.   - &#x60;PSC_EXTERNAL&#x60;: An external Platform Services Controller.   For more information see: *Vcenter.Topology.Nodes.ApplianceType*.  This property was added in __vSphere API 6.7.2__. | 
**ReplicationPartners** | **List&lt;string&gt;** | List of replication partners&#39; node identifiers. Identifiers can be either IP address or DNS resolvable name of the partner node.  This property was added in __vSphere API 6.7.2__.  This property is optional and it is only relevant when the value of type is one of *Vcenter.Topology.Nodes.ApplianceType.VCSA_EMBEDDED* or *Vcenter.Topology.Nodes.ApplianceType.PSC_EXTERNAL*.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;com.vmware.vcenter.VCenter.name&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;com.vmware.vcenter.VCenter.name&#x60;. | [optional] 
**ClientAffinity** | **string** | Identifier of the affinitized Platform Services Controller node. Identifier can be either IP address or DNS resolvable name of the affinitized node.  This property was added in __vSphere API 6.7.2__.  This property is optional and it is only relevant when the value of type is *Vcenter.Topology.Nodes.ApplianceType.VCSA_EXTERNAL*.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.VCenter.name&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.VCenter.name&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

