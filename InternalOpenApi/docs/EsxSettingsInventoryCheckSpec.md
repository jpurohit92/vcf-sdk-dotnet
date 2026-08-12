# Vcenter.Automation.OpenApi.Model.EsxSettingsInventoryCheckSpec
The Esx.Settings.Inventory.CheckSpec schema contains properties that describe the specification to be used for checking the desired software specification to a group of inventories.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SoftwareSpec** | **string** | The optional software specification identifier.  This property was added in __vSphere API 9.0.0.0__.  if missing or &#x60;null&#x60; the assigned software specifications will be checked against.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.esx.settings.repository.software_spec&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.esx.settings.repository.software_spec&#x60;. | [optional] 
**Entities** | [**EsxSettingsInventoryEntitySpec**](EsxSettingsInventoryEntitySpec.md) | The entities containing the hosts to be checked.  This property was added in __vSphere API 9.0.0.0__. | 
**Perspective** | **string** | Specifies the upgrade perspective to be used for performing checks. This field is mainly intended for VMware Cloud Foundation (VCF) environment. For VMware vSphere Foundation (VVF) environment, configuring this field is not required.  Possible values:   - &#x60;GENERAL_UPGRADE_READINESS&#x60;: Represents the initial readiness evaluation phase. This perspective checks whether the entity meets the required health criteria and passes all relevant eligibility checks to begin the upgrade process.   - &#x60;UPGRADE_PLANNING&#x60;: Represents the planning phase. This perspective determines upgrade feasibility of the entity to a designated software release. Ensures that entity meets the required health criteria and passes all relevant eligibility checks to upgrade to the specific release.   For more information see: *Esx.Settings.Inventory.CheckSpec.Perspective*.  This property was added in __vSphere API 9.1.0.0__.  Only set if specific VCF upgrade workflow perspective to be used to perform checks. If missing or &#x60;null&#x60; all the checks would be performed on entities. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

