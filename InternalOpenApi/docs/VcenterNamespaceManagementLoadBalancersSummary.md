# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementLoadBalancersSummary
The Vcenter.NamespaceManagement.LoadBalancers.Summary contains contains basic information related to the load balancer for provisioning virtual servers in the namespace.  This schema was added in __vSphere API 7.0.1.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | An DNS compliant identifier for a load balancer, which can be used to query or configure the load balancer properties.  This property was added in __vSphere API 7.0.1.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.LoadBalancerConfig&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.LoadBalancerConfig&#x60;. | 
**Provider** | **string** | Load balancer provider for the namespace.  Possible values:   - &#x60;HA_PROXY&#x60;: This constant is deprecated as of __vSphere API 9.0.0.0__. Use *Vcenter.NamespaceManagement.Networks.Edges.EdgeProvider.VSPHERE_FOUNDATION* instead.  HAProxy load balancer   - &#x60;AVI&#x60;: NSX Advanced Load Balancer  This constant was added in __vSphere API 7.0.2.0__.   For more information see: *Vcenter.NamespaceManagement.LoadBalancers.Provider*.  This property was added in __vSphere API 7.0.1.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

