# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsLogsConfigurationCore
The Vcenter.NamespaceManagement.Supervisors.Logs.ConfigurationCore represents the core configuration for a given *Vcenter.NamespaceManagement.Supervisors.Logs.ConfigurationCore.UnitType*. The Vcenter.NamespaceManagement.Supervisors.Logs.ConfigurationCore class has common set of configuration required in the request and response body.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **bool** | Specifies whether log streaming is enabled for the given unit type. If false, the content should have appropriate configuration to disable the log streaming for the given unit type. If true, the content should have appropriate configuration to enable the log streaming for the given unit type.  This property was added in __vSphere API 9.1.0.0__. | 
**Unittype** | **string** | Represents the *Vcenter.NamespaceManagement.Supervisors.Logs.ConfigurationCore.UnitType* for which the logs needs to be streamed.  Possible values:   - &#x60;SUPERVISOR&#x60;: The Supervisor unit   - &#x60;VSPHERE_POD&#x60;: The vSphere PodVM unit   For more information see: *Vcenter.NamespaceManagement.Supervisors.Logs.ConfigurationCore.UnitType*.  This property was added in __vSphere API 9.1.0.0__. | 
**Content** | **string** | Defines the configuration to be applied to the logging agent within the given unit type. The content should have a valid configuration based on the logging agent in the given unit type to stream the desired logs to the destination log server.  This property was added in __vSphere API 9.1.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

