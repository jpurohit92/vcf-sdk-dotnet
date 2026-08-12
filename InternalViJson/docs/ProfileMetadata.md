# Vcenter.ViJson.OpenApi.Model.ProfileMetadata

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | Type of the Profile  | 
**ProfileTypeName** | **string** | Type identifier for the ApplyProfile  | [optional] 
**Description** | [**ExtendedDescription**](ExtendedDescription.md) | Property which describes the profile  | [optional] 
**SortSpec** | [**List&lt;ProfileMetadataProfileSortSpec&gt;**](ProfileMetadataProfileSortSpec.md) | Property that determines a sorting order for display purposes.  If the list contains more than one sort spec, then the precedence should be determined by the list order (i.e. sort first by the first spec in the list, then sort by the second spec in the list, etc).  | [optional] 
**ProfileCategory** | **string** | Identifies the profile category that this subprofile is a part of.  The value of this string should correspond to the key value of a *ProfileCategoryMetadata* object&#39;s *ElementDescription.key* in its *ProfileCategoryMetadata.id* property.  | [optional] 
**ProfileComponent** | **string** | Property indicating that the subprofile described by this &lt;code&gt;ProfileMetadata&lt;/code&gt; object is declared in the *ProfileComponentMetadata.profileTypeNames* of the specified profile component.  The value of this property should correspond to the key value of the *ProfileComponentMetadata* object&#39;s *ElementDescription.key* in its *ProfileComponentMetadata.id* property. This property should not be present for subprofiles that are not directly declared in the *ProfileComponentMetadata.profileTypeNames* property of a *ProfileComponentMetadata* object.  | [optional] 
**OperationMessages** | [**List&lt;ProfileMetadataProfileOperationMessage&gt;**](ProfileMetadataProfileOperationMessage.md) | A list of &lt;code&gt;ProfileOperationMessage&lt;/code&gt; for this profile.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

