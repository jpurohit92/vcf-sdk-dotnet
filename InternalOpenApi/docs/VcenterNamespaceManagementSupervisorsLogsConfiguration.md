# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsLogsConfiguration
The Vcenter.NamespaceManagement.Supervisors.Logs.Configuration represents the log streaming configuration for a given *Vcenter.NamespaceManagement.Supervisors.Logs.ConfigurationCore.UnitType*.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Certificates** | **List&lt;string&gt;** | Represents a list of PEM-encoded certificates, with each string representing a single certificate. These certificates are intended for establishing secure connection between the logging agent and the destination log server.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, certificates is not required when the log streaming is being disabled. | [optional] 
**Enabled** | **bool** | Specifies whether log streaming is enabled for the given unit type. If false, the content should have appropriate configuration to disable the log streaming for the given unit type. If true, the content should have appropriate configuration to enable the log streaming for the given unit type.  This property was added in __vSphere API 9.1.0.0__. | 
**Unittype** | **string** | Represents the *Vcenter.NamespaceManagement.Supervisors.Logs.ConfigurationCore.UnitType* for which the logs needs to be streamed.  Possible values:   - &#x60;SUPERVISOR&#x60;: The Supervisor unit   - &#x60;VSPHERE_POD&#x60;: The vSphere PodVM unit   For more information see: *Vcenter.NamespaceManagement.Supervisors.Logs.ConfigurationCore.UnitType*.  This property was added in __vSphere API 9.1.0.0__. | 
**Content** | **string** | Defines the configuration to be applied to the logging agent within the given unit type. The content should have a valid configuration based on the logging agent in the given unit type to stream the desired logs to the destination log server.  This property was added in __vSphere API 9.1.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

