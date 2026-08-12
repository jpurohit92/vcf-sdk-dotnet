# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementDistributedSwitchCompatibilityFilterSpec
This schema is deprecated as of __vSphere API 9.1.0.0__.  The Vcenter.NamespaceManagement.DistributedSwitchCompatibility.FilterSpec schema contains properties used to filter the results when listing Distributed Switches (see *GET /vcenter/namespace-management/distributed-switch-compatibility*) and their compatibility information.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Compatible** | **bool** | This property is deprecated as of __vSphere API 9.1.0.0__.  Compatibility criteria for matching the filter. If true, only Distributed Switches which are compatible with vSphere Namespaces match the filter. If false, only Distributed Switches which are incompatible with vSphere Namespaces match the filter.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, both compatible and incompatible Distributed Switches match the filter. | [optional] 
**NetworkProvider** | **string** | This property is deprecated as of __vSphere API 9.1.0.0__.  The network provider whose networks will be considered. If unset, this will default to NSXT_CONTAINER_PLUGIN.  Possible values:   - &#x60;NSXT_CONTAINER_PLUGIN&#x60;: NSX Container Plugin.   - &#x60;VSPHERE_NETWORK&#x60;: vSphere Networking.  This constant was added in __vSphere API 7.0.1.0__.   - &#x60;NSX_VPC&#x60;: NSX VPC.  This constant was added in __vSphere API 9.0.0.0__.   For more information see: *Vcenter.NamespaceManagement.Clusters.NetworkProvider*.  This property was added in __vSphere API 7.0.1.0__.  This property is optional because it was added in a newer version than its parent node. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

