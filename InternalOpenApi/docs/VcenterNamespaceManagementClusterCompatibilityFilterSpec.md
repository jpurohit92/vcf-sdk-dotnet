# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementClusterCompatibilityFilterSpec
The Vcenter.NamespaceManagement.ClusterCompatibility.FilterSpec schema contains properties used to filter the results when listing clusters (see *GET /vcenter/namespace-management/cluster-compatibility*) and their compatibility information.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Compatible** | **bool** | Set this flag to true to only list vSphere clusters that are currently compatible with the Namespaces feature. If set to false, both compatible and incompatible vSphere clusters will be listed.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, both compatible and incompatible vSphere clusters will be listed. | [optional] 
**NetworkProvider** | **string** | The network provider whose networks will be considered.  Possible values:   - &#x60;NSXT_CONTAINER_PLUGIN&#x60;: NSX Container Plugin.   - &#x60;VSPHERE_NETWORK&#x60;: vSphere Networking.  This constant was added in __vSphere API 7.0.1.0__.   - &#x60;NSX_VPC&#x60;: NSX VPC.  This constant was added in __vSphere API 9.0.0.0__.   For more information see: *Vcenter.NamespaceManagement.Clusters.NetworkProvider*.  This property was added in __vSphere API 7.0.1.0__.  If missing or &#x60;null&#x60;, this will default to *Vcenter.NamespaceManagement.Clusters.NetworkProvider.NSXT_CONTAINER_PLUGIN*. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

