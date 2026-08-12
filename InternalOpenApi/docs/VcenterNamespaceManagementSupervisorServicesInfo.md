# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorServicesInfo
The Vcenter.NamespaceManagement.SupervisorServices.Info schema contains detailed information about a Supervisor Service.  This schema was added in __vSphere API 7.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | The human readable name of the Supervisor Service.  This property was added in __vSphere API 7.0.3.0__. | 
**State** | **string** | The current Vcenter.NamespaceManagement.SupervisorServices.State of the Supervisor Service.  Possible values:   - &#x60;ACTIVATED&#x60;: The is the default state of a Supervisor Service upon creation. In this state, at least one version of the Supervisor Service is activated.   - &#x60;DEACTIVATED&#x60;: The is the deactivated state of a Supervisor Service. In this state, all existing versions of the Supervisor Service will be deactivated, and cannot be activated. In addition to that, no new versions can be added to the Supervisor Service.   For more information see: *Vcenter.NamespaceManagement.SupervisorServices.State*.  This property was added in __vSphere API 7.0.3.0__. | 
**Description** | **string** | A human readable description of the Supervisor Service.  This property was added in __vSphere API 7.0.3.0__.  If missing or &#x60;null&#x60;, no description is available for the Supervisor Service. | [optional] 
**HasDefaultVersionsRegistered** | **bool** | If &#x60;true&#x60;, this Supervisor Service has at least one version registered by default on vCenter, and those default versions cannot be deleted. If &#x60;false&#x60;, this service does not have any default registered versions.  This property was added in __vSphere API 8.0.3.0__.  This property is optional because it was added in a newer version than its parent node. | [optional] 
**MustBeInstalled** | **bool** | If &#x60;true&#x60;, this Supervisor Service will be installed by default on each Supervisor, though the version may differ on different Supervisors. Users can upgrade this version later, but cannot uninstall the service. If &#x60;false&#x60;, this service will not be installed by default on Supervisors.  This property was added in __vSphere API 8.0.3.0__.  This property is optional because it was added in a newer version than its parent node. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

