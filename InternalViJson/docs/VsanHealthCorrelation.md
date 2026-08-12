# Vcenter.ViJson.OpenApi.Model.VsanHealthCorrelation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PrimaryHealthTests** | **List&lt;string&gt;** | The health test ids which indicate the primary health issues causing the current health warning so that user should address at first.  | [optional] 
**RelatedHealthTests** | **List&lt;string&gt;** | The related health test ids which may be triggered by primary health issue.  | [optional] 
**SkippedHealthTests** | **List&lt;string&gt;** | The health test ids which have been skipped and shown as green due to the prerequisite doesn&#39;t satisfy.  For example, if disk controller is not in the vSAN Hardware Compatibility List (HCL), then all of following HCL checks like driver/firmware version check will be skipped and shown as green.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

