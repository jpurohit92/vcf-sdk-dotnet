# Vcenter.Automation.OpenApi.Model.VcenterNamespacesNetworksNsxSubnetsInfo
The Vcenter.Namespaces.Networks.Nsx.Subnets.Info contains selected fields from the corresponding NSX Subnet or SubnetSet entity.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the entity within the namespace.  This property was added in __vSphere API 9.0.0.0__. | 
**Type** | **string** | The type of the entity.  Possible values:   - &#x60;SUBNET&#x60;: A *Vcenter.Namespaces.Networks.Nsx.Subnets.Entity.SUBNET* in a VPC represents an independent layer 2 broadcast domain with its associated CIDR and properties like Access mode (network advertisement), DHCP configuration etc.   - &#x60;SUBNETSET&#x60;: A *Vcenter.Namespaces.Networks.Nsx.Subnets.Entity.SUBNETSET* is a scalable grouping of VPC subnets sharing the same properties, which will allow auto-scale of networking availability to connect workloads.   For more information see: *Vcenter.Namespaces.Networks.Nsx.Subnets.Entity*.  This property was added in __vSphere API 9.0.0.0__. | 
**ApiVersion** | **string** | The NSX API version of the entity that was retrieved.  This property was added in __vSphere API 9.0.0.0__. | 
**Uid** | **string** | The unique identifier of the entity.  This property was added in __vSphere API 9.0.0.0__. | 
**Labels** | **Dictionary&lt;string, string&gt;** | The labels associated with this entity.  This property was added in __vSphere API 9.0.0.0__. | 
**AccessMode** | **string** | Access mode of entity, accessible only from within VPC or from outside the VPC. Possible values can be:     - Private: Accessible only within the VPC    - Public: Accessible outside the VPC    - PrivateTGW: Accessible within a Project    This property was added in __vSphere API 9.0.0.0__. | 
**Conditions** | [**List&lt;VcenterNamespacesNetworksNsxSubnetsCondition&gt;**](VcenterNamespacesNetworksNsxSubnetsCondition.md) | A list of conditions indicating the condition of the Subnet or SubnetSet  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

