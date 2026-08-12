# Vcenter.ViJson.OpenApi.Model.ClusterRecommendation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | Key to identify the recommendation when calling applyRecommendation.  | 
**Type** | **string** | Type of the recommendation.  This differentiates between various of recommendations aimed at achieving different goals.  | 
**Time** | **DateTime** | The time this recommendation was computed.  | 
**Rating** | **int** | A rating of the recommendation.  Valid values range from 1 (lowest confidence) to 5 (highest confidence).  | 
**Reason** | **string** | A reason code explaining why this set of migrations is being suggested.  | 
**ReasonText** | **string** | Text that provides more information about the reason code for the suggested set of migrations.  | 
**WarningText** | **string** | Text that provides warnings about potential adverse implications of applying this recommendation  | [optional] 
**WarningDetails** | [**LocalizableMessage**](LocalizableMessage.md) | Warning about potential adverse implications of applying a recommendation  | [optional] 
**Prerequisite** | **List&lt;string&gt;** | This recommendation may depend on some other recommendations.  The prerequisite recommendations are listed by their keys.  | [optional] 
**Action** | [**List&lt;ClusterAction&gt;**](ClusterAction.md) | List of actions that are executed as part of this recommendation  | [optional] 
**Target** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target object of this recommendation.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

