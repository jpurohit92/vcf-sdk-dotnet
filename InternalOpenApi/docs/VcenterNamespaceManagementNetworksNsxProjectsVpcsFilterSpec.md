# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementNetworksNsxProjectsVpcsFilterSpec
The Vcenter.NamespaceManagement.Networks.Nsx.Projects.Vpcs.FilterSpec schema contains properties used to filter the results when listing VPCs (see *GET /vcenter/namespace-management/networks/nsx/projects/{project}/vpcs*).  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Supervisor** | **string** | Identifier for the Supervisor. It must be set if *Vcenter.NamespaceManagement.Networks.Nsx.Projects.Vpcs.FilterSpec.compatible* is set.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, *Vcenter.NamespaceManagement.Networks.Nsx.Projects.Vpcs.FilterSpec.compatible* also needs missing or &#x60;null&#x60;.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.supervisor.Supervisor&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.supervisor.Supervisor&#x60;. | [optional] 
**Compatible** | **bool** | Compatibility criteria. If true, only VPCs which are compatible with the given Supervisor will be returned. If false, only VPCs incompatible with the given Supervisor will be returned.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, both compatible and incompatible VPCs will be returned. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

