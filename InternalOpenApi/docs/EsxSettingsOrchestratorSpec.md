# Vcenter.Automation.OpenApi.Model.EsxSettingsOrchestratorSpec
The Esx.Settings.OrchestratorSpec schema contains properties about the owner of a new desired state.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Owner** | **string** | Owner of the desired state. It can be the name of the owner as set by orchestrator. For example, for a software specification created by SDDC manager, it could be \&quot;SDDC-M\&quot;.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, no owner is provided during commit. | [optional] 
**OwnerData** | **string** | Private data saved by (@link owner) regarding the software specification in the repository. This data is an opaque string to vLCM and can be up to 65,535 characters long. The orchestrator will use this field to store information for identifying this image in its own catalog.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, no owner data is provided during commit. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

