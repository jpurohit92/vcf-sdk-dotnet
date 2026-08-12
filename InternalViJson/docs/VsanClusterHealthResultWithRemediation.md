# Vcenter.ViJson.OpenApi.Model.VsanClusterHealthResultWithRemediation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Label** | **string** | The label name for the vSAN health test  | [optional] 
**IssueDescription** | **string** | It explains why this specific health issue has occurred like the health threshold if has or the trigger conditions for this health issue.  This field might be unset since it will be the same as corresponding health test description if the health test only contains one issue.  | [optional] 
**IssueDetail** | [**List&lt;VsanClusterHealthResultTable&gt;**](VsanClusterHealthResultTable.md) | It&#39;s the health result table to show the detailed information of the health issue  | [optional] 
**Troubleshooting** | [**VsanHealthTroubleshooting**](VsanHealthTroubleshooting.md) | The vSAN health issue troubleshooting information.  | [optional] 
**AdditionalResources** | [**List&lt;VsanClusterHealthLink&gt;**](VsanClusterHealthLink.md) | Any additional resources like known issue KB or any kind of related documentations.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

