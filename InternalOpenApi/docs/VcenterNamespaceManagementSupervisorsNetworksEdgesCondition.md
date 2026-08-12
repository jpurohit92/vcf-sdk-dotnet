# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsNetworksEdgesCondition
The Vcenter.NamespaceManagement.Supervisors.Networks.Edges.Condition schema defines an observation of the configuration state of a Supervisor.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of an Edge&#39;s runtime state.  Possible values:   - &#x60;HEALTHY&#x60;: Condition type that represents the consolidated health status of load balancer workload(s). HEALTHY condition type with status TRUE implies that the load balancer is up and can serve requests as expected. HEALTHY condition type with status FALSE implies either the load balancer has degraded functionality or it is unavailable to serve requests.   For more information see: *Vcenter.NamespaceManagement.Supervisors.Networks.Edges.Condition.Type*.  This property was added in __vSphere API 9.0.0.0__. | 
**Status** | **string** | The status of the condition.  Possible values:   - &#x60;TRUE&#x60;: Indicates that the condition has reached the desired state.   - &#x60;FALSE&#x60;: Indicates that the condition has not reached the desired state.   - &#x60;UNKNOWN&#x60;: Indicates that the status of the condition can not be determined.   For more information see: *Vcenter.NamespaceManagement.Supervisors.Networks.Edges.Condition.Status*.  This property was added in __vSphere API 9.0.0.0__. | 
**LastTransitionTime** | **DateTime** | Last time the condition transitioned from one state to another. A transition happens when the value of status field changes.  This property was added in __vSphere API 9.0.0.0__.  if missing or &#x60;null&#x60;, there are no ongoing operations related to bringing the condition to the desired state. | [optional] 
**Reason** | **string** | A brief CamelCase message indicating details about the reason for the last transition.  This property was added in __vSphere API 9.0.0.0__. | 
**Message** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | A human-readable message that provides additional details about the last transition.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60; no additional information is available. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

