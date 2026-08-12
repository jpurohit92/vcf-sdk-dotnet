# Vcenter.Automation.OpenApi.Model.VcenterLcmUpdatePendingListResult
The Vcenter.Lcm.Update.Pending.ListResult schema contains information about the pending patch/updates for the given vCenter server.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LastCheckTime** | **DateTime** | Time when the software depo was last checked. | 
**UpdateCount** | **long** | Number of pending updates  Only set if there are available updates | [optional] 
**UpgradeCount** | **long** | Number of pending upgrades  Only set if there are available upgrades | [optional] 
**Updates** | [**List&lt;VcenterLcmUpdatePendingSummary&gt;**](VcenterLcmUpdatePendingSummary.md) | List of pending update details | 
**Issues** | [**VcenterLcmNotifications**](VcenterLcmNotifications.md) | Lists of issues encountered during pending updates retrieval.  set if any issues encountered. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

