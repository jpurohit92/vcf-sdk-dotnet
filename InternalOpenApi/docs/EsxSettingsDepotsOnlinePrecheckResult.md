# Vcenter.Automation.OpenApi.Model.EsxSettingsDepotsOnlinePrecheckResult
The Esx.Settings.Depots.Online.PrecheckResult schema contains the fields that show the details of affected baselines and desired states found in *DELETE /esx/settings/depots/online/{depot}* or *POST /esx/settings/depots/online/{depot}?action=flush* operation.  This schema was added in __vSphere API 7.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AffectedBaselines** | [**List&lt;EsxSettingsDepotsAffectedBaselineInfo&gt;**](EsxSettingsDepotsAffectedBaselineInfo.md) | Baselines affected.  This property was added in __vSphere API 7.0.3.0__.  If missing or &#x60;null&#x60;, no baseline is affected. | [optional] 
**AffectedDesiredStates** | [**List&lt;EsxSettingsDepotsAffectedDesiredStateInfo&gt;**](EsxSettingsDepotsAffectedDesiredStateInfo.md) | Desired states affected.  This property was added in __vSphere API 7.0.3.0__.  If missing or &#x60;null&#x60;, no desired state is affected. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

