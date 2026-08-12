# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementNetworksNsxProjectsVpcsCompatibilityFilterSpec
The Vcenter.NamespaceManagement.Networks.Nsx.Projects.Vpcs.Compatibility.FilterSpec schema contains properties used to filter the results when checking VPCs compatibility (see *POST /vcenter/namespace-management/networks/nsx/projects/{project}/vpcs/{vpc}?action=check-compatibility*).  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Supervisor** | **string** | Identifier for the Supervisor.  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.supervisor.Supervisor&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.supervisor.Supervisor&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

