# Vcenter.Automation.OpenApi.Model.EsxSettingsInventoryScanSpec
The Esx.Settings.Inventory.ScanSpec schema contains information that com.vmware.esx.settings.repository.Inventory#scan operation needs.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SoftwareSpec** | **string** | The optional software specification identifier.  This property was added in __vSphere API 9.0.0.0__.  if missing or &#x60;null&#x60; the assigned software specifications will be scanned against.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.esx.settings.repository.software_spec&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.esx.settings.repository.software_spec&#x60;. | [optional] 
**Entities** | [**EsxSettingsInventoryEntitySpec**](EsxSettingsInventoryEntitySpec.md) | The entities containing the cluster and hosts to be scanned.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

