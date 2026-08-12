# Vcenter.Automation.OpenApi.Model.VcenterNamespacesInstancesVsphereNetworkConfigInfo
The Vcenter.Namespaces.Instances.VsphereNetworkConfigInfo schema contains read-only information about vSphere-specific network configurations applied to a vSphere Namespace.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DefaultWorkloadNetwork** | **string** | The default workload network used for workloads when they do not explicitly specify a network placement. References one of the networks in *Vcenter.Namespaces.Instances.VsphereNetworkConfigInfo.networks*.  This property was added in __vSphere API 9.1.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.Network&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.Network&#x60;. | 
**Networks** | [**List&lt;VcenterNamespacesInstancesNetworkInfo&gt;**](VcenterNamespacesInstancesNetworkInfo.md) | List of networks available in this namespace and their status.  This property was added in __vSphere API 9.1.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

