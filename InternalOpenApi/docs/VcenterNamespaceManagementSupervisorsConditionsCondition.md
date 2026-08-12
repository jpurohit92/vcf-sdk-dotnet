# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsConditionsCondition
The Vcenter.NamespaceManagement.Supervisors.Conditions.Condition schema defines an observation of the configuration state of a Supervisor.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of the condition is a CamelCase, machine readable identifier, indicating the configuration stage. InfrastructureInitialized, ControlPlaneVMsDeployed and ControlPlaneVMsConfigured are examples of such identifiers.  This property was added in __vSphere API 8.0.0.1__. | 
**Description** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | Description of the condition type in a human readable format.  This property was added in __vSphere API 8.0.0.1__. | 
**Status** | **string** | The status of the condition.  Possible values:   - &#x60;TRUE&#x60;: Indicates that the condition has reached the desired state.   - &#x60;FALSE&#x60;: Indicates that the condition has not reached the desired state.   - &#x60;UNKNOWN&#x60;: Indicates that the status of the condition can not be determined.   For more information see: *Vcenter.NamespaceManagement.Supervisors.Conditions.Condition.Status*.  This property was added in __vSphere API 8.0.0.1__. | 
**LastTransitionTime** | **DateTime** | Last time the condition transitioned from one state to another. A transition happens when the value of status or severity field changes.  This property was added in __vSphere API 8.0.0.1__.  if missing or &#x60;null&#x60;, there are no ongoing operations related to bringing the condition to the desired state. | [optional] 
**Reason** | **string** | A brief CamelCase message indicating details about the reason for the last transition. FailedWithSystemError, ManagementDNSServersMissing and WaitForNodeUpgrade are examples of such messages.  This property was added in __vSphere API 8.0.0.1__. | 
**Severity** | **string** | Provides an explicit classification of the reason identifier. Can be set when the value of status is not TRUE.  Possible values:   - &#x60;INFO&#x60;: Informational message.   - &#x60;WARNING&#x60;: Warning message.   - &#x60;ERROR&#x60;: Error message.   For more information see: *Vcenter.NamespaceManagement.Supervisors.Conditions.Severity*.  This property was added in __vSphere API 8.0.0.1__. | 
**Messages** | [**List&lt;VcenterNamespaceManagementSupervisorsConditionsMessage&gt;**](VcenterNamespaceManagementSupervisorsConditionsMessage.md) | A list of human-readable messages that provide additional details about the last transition.  This property was added in __vSphere API 8.0.0.1__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

