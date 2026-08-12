# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementNetworksEdgesFoundationNetwork
A Vcenter.NamespaceManagement.Networks.Edges.Foundation.Network describes how packets from the load balancer reach their destinations.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NetworkType** | **string** | The type of network this interface is attached to.  Possible values:   - &#x60;SUPERVISOR_MANAGEMENT&#x60;: This network refers to the management network provided as Supervisor enablement *Vcenter.NamespaceManagement.Supervisors.ControlPlane.network*.   - &#x60;PRIMARY_WORKLOAD&#x60;: This network refers to the Supervisor default workload network provided at enablement *Vcenter.NamespaceManagement.Supervisors.Workloads.network*.   - &#x60;DVPG&#x60;: Refers to a custom Vcenter.NamespaceManagement.Networks.Edges.Foundation.DistributedPortGroupNetwork.   For more information see: *Vcenter.NamespaceManagement.Networks.Edges.Foundation.Network.NetworkType*.  This property was added in __vSphere API 9.0.0.0__. | 
**DvpgNetwork** | [**VcenterNamespaceManagementNetworksEdgesFoundationDistributedPortGroupNetwork**](VcenterNamespaceManagementNetworksEdgesFoundationDistributedPortGroupNetwork.md) | A network defines how packets reach their destination.  This property was added in __vSphere API 9.0.0.0__.  This property is optional and it is only relevant when the value of network_type is *Vcenter.NamespaceManagement.Networks.Edges.Foundation.Network.NetworkType.DVPG*. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

