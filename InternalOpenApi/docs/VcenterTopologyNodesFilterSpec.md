# Vcenter.Automation.OpenApi.Model.VcenterTopologyNodesFilterSpec
The Vcenter.Topology.Nodes.FilterSpec schema contains property used to filter the results when listing vCenter and Platform Services Controller nodes (see *GET /vcenter/topology/nodes*).  This schema was added in __vSphere API 6.7.2__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Types** | **List&lt;string&gt;** | Types of the appliance that a vCenter and Platform Services Controller node must be to match the filter (see *Vcenter.Topology.Nodes.ApplianceType*.  Possible values:   - &#x60;VCSA_EMBEDDED&#x60;: vCenter Server Appliance with an embedded Platform Services Controller.   - &#x60;VCSA_EXTERNAL&#x60;: vCenter Server Appliance with an external Platform Services Controller.   - &#x60;PSC_EXTERNAL&#x60;: An external Platform Services Controller.   For more information see: *Vcenter.Topology.Nodes.ApplianceType*.  This property was added in __vSphere API 6.7.2__.  If missing or &#x60;null&#x60; or empty, node of any ApplianceType match the filter. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

