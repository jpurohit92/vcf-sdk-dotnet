# Vcenter.Automation.OpenApi.Model.VcenterNamespacesInstancesEdgeUpdateSpec
The Vcenter.Namespaces.Instances.EdgeUpdateSpec schema contains the specification required to update Edge provider association with a vSphere Namespace.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | ID of the Edge configured with the Supervisor.  This property was added in __vSphere API 9.1.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.network.edge.Edge&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.network.edge.Edge&#x60;. | 
**EdgeProvider** | **string** | The Edge provider to be updated with a vSphere Namespace.  Possible values:   - &#x60;NSX_REGISTERED_AVI&#x60;: *Vcenter.Namespaces.Instances.EdgeProvider.NSX_REGISTERED_AVI* specifies the Avi Load Balancer (NSX Advanced Load Balancer) configured on the NSX manager, specific to Supervisors configured with network provider *Vcenter.Namespaces.Instances.NetworkProvider.NSX_VPC*, or *Vcenter.Namespaces.Instances.NetworkProvider.NSXT_CONTAINER_PLUGIN*.   For more information see: *Vcenter.Namespaces.Instances.EdgeProvider*.  This property was added in __vSphere API 9.1.0.0__. | 
**Avi** | [**VcenterNamespacesInstancesAviUpdateSpec**](VcenterNamespacesInstancesAviUpdateSpec.md) | The update spec for vSphere Namespaces associated with Avi Edge providers.  This property was added in __vSphere API 9.1.0.0__.  This property is optional and it is only relevant when the value of edge_provider is *Vcenter.Namespaces.Instances.EdgeProvider.NSX_REGISTERED_AVI*. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

