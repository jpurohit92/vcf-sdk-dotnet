# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsWorkloadsNetworksSettingsInfo
The Vcenter.NamespaceManagement.Supervisors.Workloads.Networks.Settings.Info schema contains information about workload network settings.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientIpPreservationEnabled** | **bool** | Information about whether client IP preservation is enabled for requests to the Supervisor. When set to true, the original client IP address for requests to the Supervisor will be preserved in Kubernetes API Server audit logs and Supervisor Authenticating Proxy logs for auditing purposes.  This property was added in __vSphere API 9.1.0.0__.  This property is optional because it was added in a newer version than its parent node. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

