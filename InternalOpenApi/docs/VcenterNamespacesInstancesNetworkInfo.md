# Vcenter.Automation.OpenApi.Model.VcenterNamespacesInstancesNetworkInfo
The Network schema contains information about a network and its status in the vSphere Namespace.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Network** | **string** | The network identifier.  This property was added in __vSphere API 9.1.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.Network&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.Network&#x60;. | 
**ConfigStatus** | **string** | The current configuration status of the network.  Possible values:   - &#x60;ACTIVE&#x60;: The network is active and can be used for workload consumption.   - &#x60;REMOVING&#x60;: The network is being removed and may not be used for new workloads.   For more information see: *Vcenter.Namespaces.Instances.NetworkConfigStatus*.  This property was added in __vSphere API 9.1.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

