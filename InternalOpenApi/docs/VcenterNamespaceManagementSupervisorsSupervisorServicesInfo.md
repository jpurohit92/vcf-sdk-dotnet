# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsSupervisorServicesInfo
The Vcenter.NamespaceManagement.Supervisors.SupervisorServices.Info schema contains the detailed information about a Supervisor Service on the vSphere Supervisor.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DesiredVersion** | **string** | The desired version of this Supervisor Service.  This property was added in __vSphere API 9.0.0.0__. | 
**ServiceNamespace** | **string** | Identifier of the namespace to allocate the Supervisor Service&#39;s operators.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, there may have been an error while installing the Supervisor Service or the namespace has not been created yet.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.namespaces.Instance&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.namespaces.Instance&#x60;. | [optional] 
**ConfigStatus** | **string** | Current setting for Vcenter.NamespaceManagement.Supervisors.SupervisorServices.ConfigStatus.  Possible values:   - &#x60;CONFIGURING&#x60;: The Supervisor Service is being installed.   - &#x60;REMOVING&#x60;: The Supervisor Service is being deleted.   - &#x60;CONFIGURED&#x60;: The Supervisor Service has been configured correctly (i.e. the provided YAML content has been applied successfully to the Supervisor)   - &#x60;ERROR&#x60;: A failure occurred while reconciling the Supervisor Service. User intervention may be needed.   For more information see: *Vcenter.NamespaceManagement.Supervisors.SupervisorServices.ConfigStatus*.  This property was added in __vSphere API 9.0.0.0__. | 
**Messages** | [**List&lt;VcenterNamespaceManagementSupervisorsSupervisorServicesMessage&gt;**](VcenterNamespaceManagementSupervisorsSupervisorServicesMessage.md) | Current set of messages associated with the Supervisor Service on the vSphere Supervisor.  This property was added in __vSphere API 9.0.0.0__. | 
**CurrentVersion** | **string** | The current version for the Supervisor Service.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, there is no version installed for the Supervisor Service. | [optional] 
**DisplayName** | **string** | A human readable name of the Supervisor Service.  This property was added in __vSphere API 9.0.0.0__. | 
**Description** | **string** | A human readable description of the Supervisor Service.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, the description for the Service version is empty. | [optional] 
**Prefix** | **string** | The prefix that will be added to the names of the Supervisor Service&#39;s Kubernetes resources.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, no prefix is set for this Service, or the prefix is not assigned yet. | [optional] 
**YamlServiceConfig** | **string** | The configuration parameters applied on this Supervisor Service, formatted as a base64 encoded YAML document. Any configuration that has been set will be returned as base64 encoded YAML.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, the Supervisor Service has no configuration applied. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

