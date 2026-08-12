# Vcenter.Automation.OpenApi.Model.EsxSettingsInventoryTransitionSpec
The Esx.Settings.Inventory.TransitionSpec contains properties that describes the specification such as the entities in transition operation.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Entities** | [**EsxSettingsInventoryEntitySpec**](EsxSettingsInventoryEntitySpec.md) | Specification of entities on which the specified operation should be invoked. Currently only list of clusters and hosts are supported. Other entity types like datacenter, folder or VC are unsupported for now. Support for the same will be added in future releases and hence provision is being made in API/interfaces.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

