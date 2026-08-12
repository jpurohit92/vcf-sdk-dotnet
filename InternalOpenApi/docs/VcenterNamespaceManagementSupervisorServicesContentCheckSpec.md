# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorServicesContentCheckSpec
The Vcenter.NamespaceManagement.SupervisorServices.ContentCheckSpec schema provides a specification required for validation checks on the content of a Supervisor Service version.  This schema was added in __vSphere API 7.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Content** | **string** | The content of a Supervisor Service version, which shall be base64 encoded.  This property was added in __vSphere API 7.0.3.0__.  If missing or &#x60;null&#x60;, the content shall be provided separately. In the current release, this field is required, otherwise &#x60;InvalidArgument&#x60; will be thrown. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

