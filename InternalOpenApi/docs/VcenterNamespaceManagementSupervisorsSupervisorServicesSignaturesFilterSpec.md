# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsSupervisorServicesSignaturesFilterSpec
The Vcenter.NamespaceManagement.Supervisors.SupervisorServices.Signatures.FilterSpec schema contains properties used to filter the results when listing Signatures (see *GET /vcenter/namespace-management/supervisors/supervisor-services/signatures*).  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Supervisor** | **string** | Identifier of the Supervisor.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, no filtering will be performed by Supervisor.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.supervisor.Supervisor&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.supervisor.Supervisor&#x60;. | [optional] 
**Service** | **string** | Identifier for the Supervisor Service.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, no filtering will be performed by Supervisor Service.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.SupervisorService&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.SupervisorService&#x60;. | [optional] 
**VarVersion** | **string** | Identifier for the Supervisor Service version.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, no filtering will be performed by Supervisor Service version.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.supervisor_services.Version&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.supervisor_services.Version&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

