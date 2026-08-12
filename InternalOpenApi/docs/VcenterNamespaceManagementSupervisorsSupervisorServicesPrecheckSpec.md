# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsSupervisorServicesPrecheckSpec
The Vcenter.NamespaceManagement.Supervisors.SupervisorServices.PrecheckSpec schema contains the specification required to check whether a Supervisor Service version is compatible with the vSphere Supervisor.  This schema was added in __vSphere API 8.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TargetVersion** | **string** | Identifier of the Supervisor Service version that the prechecks are running for.  This property was added in __vSphere API 8.0.3.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.supervisor_services.Version&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.supervisor_services.Version&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

