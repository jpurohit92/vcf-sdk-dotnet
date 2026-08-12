# Vcenter.ViJson.OpenApi.Model.EamObjectRuntimeInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | The health of the managed entity.  This denotes how well the entity conforms to the goal state.  See also *EamObjectRuntimeInfoStatus_enum*.  | 
**Issue** | [**List&lt;Issue&gt;**](Issue.md) | Current issues that have been detected for this entity.  Each issue can be remediated by invoking *EamObject.Resolve* or *EamObject.ResolveAll*.  | [optional] 
**GoalState** | **string** | The desired state of the entity.  See also *EamObjectRuntimeInfoGoalState_enum*.  | 
**Entity** | [**ManagedObjectReference**](ManagedObjectReference.md) | The *Agent* or *Agency* with which this &lt;code&gt;RuntimeInfo&lt;/code&gt; object is associated.  Refers instance of *EamObject*.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

