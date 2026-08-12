# Vcenter.ViJson.OpenApi.Model.HostProfileSerializedHostProfileSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProfileConfigString** | **string** | Representation of the profile in the string form.  | 
**ValidatorHost** | [**ManagedObjectReference**](ManagedObjectReference.md) | Host for profile validation.  This can be a host on which the profile is intended to be used.  Refers instance of *HostSystem*.  | [optional] 
**Validating** | **bool** | If \&quot;false\&quot;, then the host profile will be saved without being validated.  The default if not specified is \&quot;true\&quot;. This option should be used with caution, since the resulting host profile will not be checked for errors.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

