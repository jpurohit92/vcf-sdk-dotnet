# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsSupervisorServicesSummary
The Vcenter.NamespaceManagement.Supervisors.SupervisorServices.Summary schema contains the basic information about a Supervisor Service on the vSphere Supervisor.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SupervisorService** | **string** | The identifier of the Supervisor Service.  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.SupervisorService&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.SupervisorService&#x60;. | 
**DesiredVersion** | **string** | The desired version of this Supervisor Service.  This property was added in __vSphere API 9.0.0.0__. | 
**ConfigStatus** | **string** | Current setting for Vcenter.NamespaceManagement.Supervisors.SupervisorServices.ConfigStatus.  Possible values:   - &#x60;CONFIGURING&#x60;: The Supervisor Service is being installed.   - &#x60;REMOVING&#x60;: The Supervisor Service is being deleted.   - &#x60;CONFIGURED&#x60;: The Supervisor Service has been configured correctly (i.e. the provided YAML content has been applied successfully to the Supervisor)   - &#x60;ERROR&#x60;: A failure occurred while reconciling the Supervisor Service. User intervention may be needed.   For more information see: *Vcenter.NamespaceManagement.Supervisors.SupervisorServices.ConfigStatus*.  This property was added in __vSphere API 9.0.0.0__. | 
**CurrentVersion** | **string** | The current version for the Supervisor Service.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, there is no version installed for the Supervisor Service. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

