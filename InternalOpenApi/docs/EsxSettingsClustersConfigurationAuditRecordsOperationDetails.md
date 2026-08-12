# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersConfigurationAuditRecordsOperationDetails
The Esx.Settings.Clusters.Configuration.AuditRecords.OperationDetails schema contains Operation Details of an operation  This schema was added in __vSphere API 8.0.2.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Error** | **Object** | Error occurred during the operation  This property was added in __vSphere API 8.0.2.0__.  error shall only be set if configmanager operation is a task | [optional] 
**TaskId** | **string** | TaskId of the operation  This property was added in __vSphere API 8.0.2.0__.  taskId shall only be set if configmanager operation is a task  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.cis.task&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.cis.task&#x60;. | [optional] 
**DraftId** | **string** | Draft ID of the draft operation  This property was added in __vSphere API 8.0.2.0__.  draftId shall only be set if this is an operation on draft  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.esx.settings.draft&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.esx.settings.draft&#x60;. | [optional] 
**Cancelled** | **bool** | Indicates if the operation was cancelled  This property was added in __vSphere API 8.0.2.0__.  cancelled shall only be set if configmanager operation is a task | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

