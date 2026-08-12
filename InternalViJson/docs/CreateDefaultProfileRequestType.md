# Vcenter.ViJson.OpenApi.Model.CreateDefaultProfileRequestType
The parameters of *HostProfileManager.CreateDefaultProfile*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProfileType** | **string** | Type of profile to create. The profile types are system-defined (*ApplyProfile*.*ApplyProfile.profileTypeName*).  | 
**ProfileTypeName** | **string** | If specified, the method returns a profile object containing data for the named profile. The type name does not have to be system-defined. A user-defined profile can include various dynamically-defined profiles.  | [optional] 
**Profile** | [**ManagedObjectReference**](ManagedObjectReference.md) | Base profile used during the operation.  Refers instance of *Profile*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

