# Vcenter.ViJson.OpenApi.Model.VSANEntityCompatibilityResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Entity** | [**ManagedObjectReference**](ManagedObjectReference.md) | Target entity, either host or cluster  Refers instance of *ManagedEntity*.  | 
**Compatible** | **bool** | Overall compatibility status of this target.  | 
**IncompatibleReasons** | [**List&lt;LocalizableMessage&gt;**](LocalizableMessage.md) | A list of messages to indicate detailed information about target incompatibile reason.  | [optional] 
**ExtendedAttributes** | [**List&lt;KeyAnyValue&gt;**](KeyAnyValue.md) | A list of extended attributes to present extra information of target entity.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

