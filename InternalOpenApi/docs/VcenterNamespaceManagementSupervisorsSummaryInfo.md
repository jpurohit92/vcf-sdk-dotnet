# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsSummaryInfo
The Vcenter.NamespaceManagement.Supervisors.Summary.Info schema contains the basic information about the statistics and status related to the Supervisor.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the Supervisor.  This property was added in __vSphere API 8.0.0.1__. | 
**Apiendpoint** | **string** | The Supervisor API endpoint used by users to manipulate Supervisor resources.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, the API server is not yet configured. | [optional] 
**Stats** | [**VcenterNamespaceManagementSupervisorsSummaryStats**](VcenterNamespaceManagementSupervisorsSummaryStats.md) | Basic runtime statistics for the Supervisor.  This property was added in __vSphere API 8.0.0.1__. | 
**ConfigStatus** | **string** | Current status of reaching the desired state configuration for the Supervisor.  Possible values:   - &#x60;CONFIGURING&#x60;: The Namespace configuration is being applied to the Supervisor.   - &#x60;REMOVING&#x60;: The Namespace configuration is being removed from the Supervisor.   - &#x60;RUNNING&#x60;: The Supervisor is configured correctly with the Namespace configuration.   - &#x60;ERROR&#x60;: Failed to apply the Namespace configuration to the Supervisor, user intervention needed.   For more information see: *Vcenter.NamespaceManagement.Supervisors.Summary.ConfigStatus*.  This property was added in __vSphere API 8.0.0.1__. | 
**KubernetesStatus** | **string** | Current Status of the Supervisor&#39;s ability to deploy pods.  Possible values:   - &#x60;READY&#x60;: The Supervisor is able to accept pods.   - &#x60;WARNING&#x60;: The Supervisor may be able to accept pods, but has warning messages.   - &#x60;ERROR&#x60;: The Supervisor may not be able to accept pods and has error messages.   For more information see: *Vcenter.NamespaceManagement.Supervisors.Summary.KubernetesStatus*.  This property was added in __vSphere API 8.0.0.1__. | 
**Messages** | [**List&lt;VcenterNamespaceManagementSupervisorsSummaryMessage&gt;**](VcenterNamespaceManagementSupervisorsSummaryMessage.md) | Current set of messages associated with the Supervisor.  This property was added in __vSphere API 9.1.0.0__.  This property is optional because it was added in a newer version than its parent node. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

