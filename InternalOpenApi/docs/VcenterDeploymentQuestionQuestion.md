# Vcenter.Automation.OpenApi.Model.VcenterDeploymentQuestionQuestion
The Vcenter.Deployment.Question.Question schema contains properties to describe a deployment question.  This schema was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Id of the question raised.  This property was added in __vSphere API 6.7__. | 
**Question** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | Message describing the question.  This property was added in __vSphere API 6.7__. | 
**Type** | **string** | Type of the question raised.  Possible values:   - &#x60;YES_NO&#x60;: Question with answer values Yes/No.   - &#x60;OK_CANCEL&#x60;: Question with answer values Ok/Cancel.   - &#x60;ABORT_RETRY_IGNORE&#x60;: Question with answer values Abort/Retry/Ignore.   For more information see: *Vcenter.Deployment.Question.QuestionType*.  This property was added in __vSphere API 6.7__. | 
**DefaultAnswer** | **string** | Default answer value.  This property was added in __vSphere API 6.7__. | 
**PossibleAnswers** | **List&lt;string&gt;** | Possible answers values.  This property was added in __vSphere API 6.7__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

