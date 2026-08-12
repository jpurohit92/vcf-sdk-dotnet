# Vcenter.ViJson.OpenApi.Model.VsanHostVmdkLoadTestResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Hostname** | **string** | The host name.  | 
**IssueFound** | **bool** | False either indicate one or more VMDK test result is failed in host VMDK load test or issues found in preparing VMDK or cleaning up VMDK.  | 
**FaultMessage** | **string** | The error message when there is any issue found  | [optional] 
**VmdkResults** | [**List&lt;VsanVmdkLoadTestResult&gt;**](VsanVmdkLoadTestResult.md) | The VMDK load test result on the host  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

