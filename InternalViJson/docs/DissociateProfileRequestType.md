# Vcenter.ViJson.OpenApi.Model.DissociateProfileRequestType
The parameters of *Profile.DissociateProfile*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Entity** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | List of entities. The vCenter Server will remove the associations that the profile has with the entities in the list. If unset, the Server removes all the associations that the profile has with any managed entities in the inventory. If the specified entity is not associated with the profile, the Server does not perform any action.  Refers instances of *ManagedEntity*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

