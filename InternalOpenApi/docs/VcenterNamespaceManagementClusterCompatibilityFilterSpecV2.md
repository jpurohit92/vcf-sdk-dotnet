# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementClusterCompatibilityFilterSpecV2
The Vcenter.NamespaceManagement.ClusterCompatibility.FilterSpecV2 schema contains properties used to filter the results when listing clusters (see *GET /vcenter/namespace-management/cluster-compatibility/v2*) and their compatibility information.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Compatible** | **bool** | Set this flag to true to only return vSphere clusters that are currently compatible with the Namespaces feature. If set to false, both compatible and incompatible vSphere clusters will be returned.  This property was added in __vSphere API 8.0.0.1__.  If missing or &#x60;null&#x60;, both compatible and incompatible vSphere clusters will be listed. | [optional] 
**NetworkProvider** | **string** | The network type that will be considered. A Supervisor can only be enabled with this network type if all hosts are compatible for this specific network type.  Possible values:   - &#x60;NSXT&#x60;:   Indicates an NSX backed network.   - &#x60;VSPHERE&#x60;:   Indicates vSphere Networking.   - &#x60;NSX_VPC&#x60;:   Indicates an NSX VPC backed network.  This constant was added in __vSphere API 9.0.0.0__.   For more information see: *Vcenter.NamespaceManagement.Supervisors.Networks.Workload.NetworkType*.  This property was added in __vSphere API 8.0.0.1__.  If missing or &#x60;null&#x60;, this will default to *Vcenter.NamespaceManagement.Supervisors.Networks.Workload.NetworkType.NSXT*. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

