# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorServicesSummary
The Vcenter.NamespaceManagement.SupervisorServices.Summary schema contains the basic information about a Supervisor Service version.  This schema was added in __vSphere API 7.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SupervisorService** | **string** | The identifier of the Supervisor Service.  This property was added in __vSphere API 7.0.3.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.SupervisorService&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.SupervisorService&#x60;. | 
**DisplayName** | **string** | The human readable name of the Supervisor Service.  This property was added in __vSphere API 7.0.3.0__. | 
**State** | **string** | The current Vcenter.NamespaceManagement.SupervisorServices.State of the Supervisor Service.  Possible values:   - &#x60;ACTIVATED&#x60;: The is the default state of a Supervisor Service upon creation. In this state, at least one version of the Supervisor Service is activated.   - &#x60;DEACTIVATED&#x60;: The is the deactivated state of a Supervisor Service. In this state, all existing versions of the Supervisor Service will be deactivated, and cannot be activated. In addition to that, no new versions can be added to the Supervisor Service.   For more information see: *Vcenter.NamespaceManagement.SupervisorServices.State*.  This property was added in __vSphere API 7.0.3.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

