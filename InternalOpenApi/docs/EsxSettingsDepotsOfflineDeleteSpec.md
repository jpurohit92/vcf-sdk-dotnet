# Vcenter.Automation.OpenApi.Model.EsxSettingsDepotsOfflineDeleteSpec
The Esx.Settings.Depots.Offline.DeleteSpec schema contains the information for depot delete or flush operation.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Force** | **bool** | Whether to forcibly delete the depot. When it is set, the depot data are removed from vCenter regardless of whether they are in use or not. Thus, keep in mind the need to add the depot content that is used by desired images or baselines before running any operation on these desired images or baselines; otherwise, operations will fail with depot content missing related errors.   The suggested workflow is to try to delete without force. After understanding what will be affected and how to recover the related depot content, delete forcibly.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, will not perform forcible deletion. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

