# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsLogsConfigurationSummary
The Vcenter.NamespaceManagement.Supervisors.Logs.ConfigurationSummary represents the summary of log streaming configuration set in the Supervisor for the given *Vcenter.NamespaceManagement.Supervisors.Logs.ConfigurationCore.UnitType*. It includes whether the log streaming is enabled, the logging agent configuration and its status.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | Represents the status of configuration applied to the logging agent within the Supervisor.  Possible values:   - &#x60;RECEIVED&#x60;: The RECEIVED status represents the configuration is received and being applied   - &#x60;CONFIGURED&#x60;: The CONFIGURED status represents the configuration is applied successfully   - &#x60;FAILED&#x60;: The FAILED status represents the configuration failed to apply   For more information see: *Vcenter.NamespaceManagement.Supervisors.Logs.ConfigurationSummary.Status*.  This property was added in __vSphere API 9.1.0.0__. | 
**Message** | **string** | Represents the human-readable message for a given status  This property was added in __vSphere API 9.1.0.0__. | 
**Enabled** | **bool** | Specifies whether log streaming is enabled for the given unit type. If false, the content should have appropriate configuration to disable the log streaming for the given unit type. If true, the content should have appropriate configuration to enable the log streaming for the given unit type.  This property was added in __vSphere API 9.1.0.0__. | 
**Unittype** | **string** | Represents the *Vcenter.NamespaceManagement.Supervisors.Logs.ConfigurationCore.UnitType* for which the logs needs to be streamed.  Possible values:   - &#x60;SUPERVISOR&#x60;: The Supervisor unit   - &#x60;VSPHERE_POD&#x60;: The vSphere PodVM unit   For more information see: *Vcenter.NamespaceManagement.Supervisors.Logs.ConfigurationCore.UnitType*.  This property was added in __vSphere API 9.1.0.0__. | 
**Content** | **string** | Defines the configuration to be applied to the logging agent within the given unit type. The content should have a valid configuration based on the logging agent in the given unit type to stream the desired logs to the destination log server.  This property was added in __vSphere API 9.1.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

