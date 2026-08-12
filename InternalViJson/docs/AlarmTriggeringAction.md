# Vcenter.ViJson.OpenApi.Model.AlarmTriggeringAction

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Action** | [**Action**](Action.md) | The action to be done when the alarm is triggered.  | 
**TransitionSpecs** | [**List&lt;AlarmTriggeringActionTransitionSpec&gt;**](AlarmTriggeringActionTransitionSpec.md) | Indicates on which transitions this action executes and repeats.  This is optional only for backwards compatibility.  | [optional] 
**Green2yellow** | **bool** | Deprecated as of vSphere API 4.0, use *AlarmTriggeringActionTransitionSpec* .  Flag to specify that the alarm should trigger on a transition from green to yellow.  | 
**Yellow2red** | **bool** | Deprecated as of vSphere API 4.0, use *AlarmTriggeringActionTransitionSpec* .  Flag to specify that the alarm should trigger on a transition from yellow to red.  | 
**Red2yellow** | **bool** | Deprecated as of vSphere API 4.0, use *AlarmTriggeringActionTransitionSpec* .  Flag to specify that the alarm should trigger on a transition from red to yellow.  | 
**Yellow2green** | **bool** | Deprecated as of vSphere API 4.0, use *AlarmTriggeringActionTransitionSpec* .  Flag to specify that the alarm should trigger on a transition from yellow to green.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

