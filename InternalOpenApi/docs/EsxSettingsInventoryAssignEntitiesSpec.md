# Vcenter.Automation.OpenApi.Model.EsxSettingsInventoryAssignEntitiesSpec
The Esx.Settings.Inventory.AssignEntitiesSpec contains properties used to assign a software specification from the repository to a list of entities.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SoftwareSpecId** | **string** | The software spec in the repository that will be assigned to the list of entities.  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.esx.settings.repository.software_spec&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.esx.settings.repository.software_spec&#x60;. | 
**Entities** | [**EsxSettingsInventoryEntitySpec**](EsxSettingsInventoryEntitySpec.md) | Specification of entities on which the specified operation should be invoked.  This property was added in __vSphere API 9.0.0.0__. | 
**Orchestrator** | [**EsxSettingsOrchestratorSpec**](EsxSettingsOrchestratorSpec.md) | Orchestrator specification of the desired state created during assign operation on the entities. It is used to ensure the authorized owner can make modification of desired state.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, no orchestrator detail is provided during the assign operation.   Note:   1. It is used by vLCM orchestrators like SDDC Manager to manage the desired state. For a non-orchestrator user i.e. a VC user, it must be unset.   2. Setting it prevents other users from modifying the committed desired state. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

