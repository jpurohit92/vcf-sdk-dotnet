# Vcenter.ViJson.OpenApi.Model.ObjectUpdate

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Kind** | **ObjectUpdateKindEnum** | Kind of update that caused the filter to report a change.  | 
**Obj** | [**ManagedObjectReference**](ManagedObjectReference.md) | Reference to the managed object to which this update applies.  | 
**ChangeSet** | [**List&lt;PropertyChange&gt;**](PropertyChange.md) | Optional set of changes to the object.  Present only if the \&quot;kind\&quot; is either \&quot;modify\&quot; or \&quot;enter\&quot;.  | [optional] 
**MissingSet** | [**List&lt;MissingProperty&gt;**](MissingProperty.md) | Properties whose value could not be retrieved and their associated faults.  Present only if the \&quot;kind\&quot; is either \&quot;modify\&quot; or \&quot;enter\&quot;.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

