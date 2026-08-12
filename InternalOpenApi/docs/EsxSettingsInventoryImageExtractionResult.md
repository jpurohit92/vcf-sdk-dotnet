# Vcenter.Automation.OpenApi.Model.EsxSettingsInventoryImageExtractionResult
The Esx.Settings.Inventory.ImageExtractionResult schema contains properties that describes the status and brief details about the image extract operation invoked on an entity.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | Describes the status of the specified operation invoked the entity.  Possible values:   - &#x60;COMPLETED&#x60;: Describes the specified operation is completed successfully.   - &#x60;FAILED&#x60;: Describes the specified operation failed during its execution.   - &#x60;IN_PROGRESS&#x60;: Describes the specified operation is still in-progress.   For more information see: *Esx.Settings.Inventory.ExtractStatus*.  This property was added in __vSphere API 9.0.0.0__. | 
**UniformImage** | **bool** | Describes if the image present on the entity is uniform or not. In case of standalone host this property will always be true. In case of clusters, if all hosts within the cluster are running same image then this property will be set to &#x60;true&#x60; else &#x60;false&#x60;. In case of folders/datacenters, if all the standalone hosts and clusters within them are running the same image, then property will be set to &#x60;true&#x60; else &#x60;false&#x60;.  This property was added in __vSphere API 9.0.0.0__. | 
**Notifications** | [**EsxSettingsNotifications**](EsxSettingsNotifications.md) | Notifications raised during the execution of the specified operation.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

