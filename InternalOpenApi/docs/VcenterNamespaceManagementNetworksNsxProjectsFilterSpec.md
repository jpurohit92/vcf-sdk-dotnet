# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementNetworksNsxProjectsFilterSpec
The Vcenter.NamespaceManagement.Networks.Nsx.Projects.FilterSpec schema contains properties used to filter the results when listing Projects (see *GET /vcenter/namespace-management/networks/nsx/projects*).  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Compatible** | **bool** | Compatibility criteria. If true, only Projects which are compatible with Supervisor enablement will be returned. If false, only Projects incompatible with Supervisor enablement will be returned.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, both compatible and incompatible Projects will be returned. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

