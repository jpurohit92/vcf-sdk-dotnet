# Vcenter.ViJson.OpenApi.Model.VsanHealthDataDrivenAction

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** | The descriptive message for explaining what the action it is.  Notice it can support the following mark up tags. 1\\. Hyperlink &amp;lt;tag.link&amp;gt;{link\\_content}&amp;lt;/tag.link&amp;gt; 2\\. Host entity &amp;lt;tag.icon.host&amp;gt;${host\\_ip}&amp;lt;/tag.icon.host&amp;gt;  | 
**ApiAction** | [**VsanDataDrivenAPIAction**](VsanDataDrivenAPIAction.md) | The API based action for troubleshooting or remediating a health issue, which can be triggered either from UI or automation script.  | 
**Confirmation** | [**VsanHealthConfirmationDialog**](VsanHealthConfirmationDialog.md) | The object which defines a confirmation dialog.  This is optional. If it&#39;s unset, UI won&#39;t show confirmation dialog after clicking the button.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

