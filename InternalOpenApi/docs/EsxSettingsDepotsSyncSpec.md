# Vcenter.Automation.OpenApi.Model.EsxSettingsDepotsSyncSpec
The Esx.Settings.Depots.SyncSpec schema defines the information used to sync online depots.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cleanup** | **bool** | Whether to clean up all online depots before depot sync. When an online depot is cleaned up, all the data from this online depot, including the old content existing in vCenter but deprecated at the online depot, will be removed from disk, DB, and memory.   Depot content not from online depots is untouched.   Depot cleanup temporarily removes the online depot content which may be needed for image operations. Thus, it is suggested to avoid performing image operations that need online depot content when syncing depot with cleanup.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, will not perform depot cleanup. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

