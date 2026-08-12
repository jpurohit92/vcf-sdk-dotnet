# Vcenter.ViJson.OpenApi.Model.GenerateHostConfigTaskSpecRequestType
The parameters of *HostProfileManager.GenerateHostConfigTaskSpec_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HostsInfo** | [**List&lt;StructuredCustomizations&gt;**](StructuredCustomizations.md) | List of host data for which configuration task list needs to be generated. The *StructuredCustomizations.customizations* value should be provided only if the host customization data for that host is invalid. If this property is not provided, the API will use the host customization data stored in VC and generate task list.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

