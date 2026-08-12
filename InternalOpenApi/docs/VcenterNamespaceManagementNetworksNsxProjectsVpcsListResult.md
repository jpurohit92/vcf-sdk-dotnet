# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementNetworksNsxProjectsVpcsListResult
The Vcenter.NamespaceManagement.Networks.Nsx.Projects.Vpcs.ListResult schema represents the result of the *GET /vcenter/namespace-management/networks/nsx/projects/{project}/vpcs* operation. With *Vcenter.NamespaceManagement.Networks.Nsx.Projects.Vpcs.FilterSpec.compatible* set to true, will only return compatible VPCs that have been pre-created on NSX, filtering out pre-created VPCs from Supervisor or VCF Automation.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vpcs** | [**List&lt;VcenterNamespaceManagementNetworksNsxProjectsVpcsInfo&gt;**](VcenterNamespaceManagementNetworksNsxProjectsVpcsInfo.md) | List of all VPCs.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

