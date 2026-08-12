# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementNetworksNsxDistributedSwitchesFilterSpec
The Vcenter.NamespaceManagement.Networks.Nsx.DistributedSwitches.FilterSpec schema contains properties used to filter the results when listing Distributed Switches (see *GET /vcenter/namespace-management/networks/nsx/distributed-switches*).  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Compatible** | **bool** | Compatibility criteria. If true, only Distributed Switches compatible with the vSphere Namespaces will be returned. If false, only Distributed Switches incompatible with the vSphere Namespaces will be returned.  This property was added in __vSphere API 8.0.0.1__.  If missing or &#x60;null&#x60;, both compatible and incompatible Distributed Switches will be returned. | [optional] 
**Cluster** | **string** | If specified, distributed switches across the hosts in the cluster will be returned. This must not be specified if *Vcenter.NamespaceManagement.Networks.Nsx.DistributedSwitches.FilterSpec.zones* is specified.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, filtering on a particular cluster will not occur.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;ClusterComputeResource&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;ClusterComputeResource&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

