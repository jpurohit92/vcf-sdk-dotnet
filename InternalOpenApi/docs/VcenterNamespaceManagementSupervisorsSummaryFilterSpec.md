# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsSummaryFilterSpec
A Vcenter.NamespaceManagement.Supervisors.Summary.FilterSpec can be specified to filter summary output by any allowed criteria. An empty Vcenter.NamespaceManagement.Supervisors.Summary.FilterSpec will cause all results of the query to be returned.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConfigStatus** | **string** | Matches Supervisors with *Vcenter.NamespaceManagement.Supervisors.Summary.Info.config_status* equal to the specified value.  Possible values:   - &#x60;CONFIGURING&#x60;: The Namespace configuration is being applied to the Supervisor.   - &#x60;REMOVING&#x60;: The Namespace configuration is being removed from the Supervisor.   - &#x60;RUNNING&#x60;: The Supervisor is configured correctly with the Namespace configuration.   - &#x60;ERROR&#x60;: Failed to apply the Namespace configuration to the Supervisor, user intervention needed.   For more information see: *Vcenter.NamespaceManagement.Supervisors.Summary.ConfigStatus*.  This property was added in __vSphere API 8.0.0.1__.  if missing or &#x60;null&#x60; this filter is not applied. | [optional] 
**KubernetesStatus** | **string** | Matches Supervisors with the *Vcenter.NamespaceManagement.Supervisors.Summary.Info.kubernetes_status* equal to the specified value.  Possible values:   - &#x60;READY&#x60;: The Supervisor is able to accept pods.   - &#x60;WARNING&#x60;: The Supervisor may be able to accept pods, but has warning messages.   - &#x60;ERROR&#x60;: The Supervisor may not be able to accept pods and has error messages.   For more information see: *Vcenter.NamespaceManagement.Supervisors.Summary.KubernetesStatus*.  This property was added in __vSphere API 8.0.0.1__.  if missing or &#x60;null&#x60; this filter is not applied. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

