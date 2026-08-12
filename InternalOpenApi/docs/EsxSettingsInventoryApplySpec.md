# Vcenter.Automation.OpenApi.Model.EsxSettingsInventoryApplySpec
The Esx.Settings.Inventory.ApplySpec schema contains properties that describe the specification to be used for applying the desired software specification to a group of inventories.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AcceptEula** | **bool** |   Accept the VMware End User License Agreement (EULA) before starting the com.vmware.esx.settings.repository.Inventory#apply operation.   The VMware EULA is available for download at, https://www.vmware.com/download/eula.html  This property was added in __vSphere API 9.0.0.0__.  if missing or &#x60;null&#x60; the com.vmware.esx.settings.repository.Inventory#apply operation could fail due to the EULA not being accepted. | [optional] 
**Entities** | [**EsxSettingsInventoryEntitySpec**](EsxSettingsInventoryEntitySpec.md) | The entities containing the hosts to be remediated.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

