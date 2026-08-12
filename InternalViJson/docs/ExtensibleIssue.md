# Vcenter.ViJson.OpenApi.Model.ExtensibleIssue

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **int** | A unique identifier per &lt;code&gt;Issue&lt;/code&gt; instance.  | 
**Description** | **string** | A localized message describing the issue.  | 
**Time** | **DateTime** | The point in time when this issue was generated.  Note that issues can be regenerated periodically, so this time does not necessarily reflect the first time the issue was detected.  | 
**TypeId** | **string** | Unique string for this type of issue.  The type must match an event registered by the solution as part of its extension.  | 
**Argument** | [**List&lt;KeyAnyValue&gt;**](KeyAnyValue.md) | Arguments associated with the typeId.  | [optional] 
**Target** | [**ManagedObjectReference**](ManagedObjectReference.md) | A managed object reference to the object this issue is related to.  Refers instance of *ManagedEntity*.  | [optional] 
**Agent** | [**ManagedObjectReference**](ManagedObjectReference.md) | An optional agent this issue pertains  Refers instance of *Agent*.  | [optional] 
**Agency** | [**ManagedObjectReference**](ManagedObjectReference.md) | An optional agency this issue pertains  Refers instance of *Agency*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

