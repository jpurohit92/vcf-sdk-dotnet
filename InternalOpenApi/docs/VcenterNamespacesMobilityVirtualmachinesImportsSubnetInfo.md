# Vcenter.Automation.OpenApi.Model.VcenterNamespacesMobilityVirtualmachinesImportsSubnetInfo
The Vcenter.Namespaces.Mobility.Virtualmachines.Imports.SubnetInfo schema contains information identifying a Subnet.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the Subnet to which the network device should be connected.    This name corresponds to the *Vcenter.Namespaces.Networks.Nsx.Subnets.Info.name* field retrieved from the Subnets API.  This property was added in __vSphere API 9.0.0.0__. | 
**Type** | **string** | The type of the Subnet, indicating whether it is a SUBNET or SUBNETSET.    This corresponds to the *Vcenter.Namespaces.Networks.Nsx.Subnets.Info.type* field retrieved from the Subnets API.  Possible values:   - &#x60;SUBNET&#x60;: A *Vcenter.Namespaces.Mobility.Virtualmachines.Imports.SubnetInfo.Entity.SUBNET* in a VPC represents an independent layer 2 broadcast domain with its associated CIDR and properties like Access mode (network advertisement), DHCP configuration etc.   - &#x60;SUBNETSET&#x60;: A *Vcenter.Namespaces.Mobility.Virtualmachines.Imports.SubnetInfo.Entity.SUBNETSET* is a scalable grouping of VPC subnets sharing the same properties, which will allow auto-scale of networking availability to connect workloads.   For more information see: *Vcenter.Namespaces.Mobility.Virtualmachines.Imports.SubnetInfo.Entity*.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, the *Vcenter.Namespaces.Mobility.Virtualmachines.Imports.SubnetInfo.name* will be used to find the appropriate SUBNET or SUBNETSET. This is required if the same name is found for both SUBNET and SUBNETSET. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

