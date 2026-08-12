# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsWorkloadsNetworksSettingsUpdateSpec
The Vcenter.NamespaceManagement.Supervisors.Workloads.Networks.Settings.UpdateSpec schema contains updates to workload network settings.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientIpPreservationEnabled** | **bool** | Enable client IP preservation for requests to the Supervisor. When set to true, the original client IP address for requests to the Supervisor will be preserved in Kubernetes API Server audit logs and Supervisor Authenticating Proxy logs for auditing purposes.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, no change will be made to the Supervisor. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

