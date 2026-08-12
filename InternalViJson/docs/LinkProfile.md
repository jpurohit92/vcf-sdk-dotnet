# Vcenter.ViJson.OpenApi.Model.LinkProfile
The LinkProfile data object represents a subprofile for links connected to virtual switch. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **bool** | Indicates whether the profile is enabled.  | 
**Policy** | [**List&lt;ProfilePolicy&gt;**](ProfilePolicy.md) | The list of policies comprising the profile.  A *ProfilePolicy* stores one or more configuration data values in a *PolicyOption*. The policy option is one of the configuration options from the *ProfilePolicyMetadata*.*ProfilePolicyMetadata.possibleOption* list.  | [optional] 
**ProfileTypeName** | **string** | Identifies the profile type.  | [optional] 
**ProfileVersion** | **string** | Profile engine version.  | [optional] 
**Property** | [**List&lt;ProfileApplyProfileProperty&gt;**](ProfileApplyProfileProperty.md) | List of subprofiles for this profile.  This list can change depending on which profile plug-ins are available in the system. Subprofiles can be nested to arbitrary depths to represent host capabilities.  | [optional] 
**Favorite** | **bool** | Indicates whether this profile is marked as \&quot;favorite\&quot;.  | [optional] 
**ToBeMerged** | **bool** | Indicates whether this profile is marked as to-be-merged.  | [optional] 
**ToReplaceWith** | **bool** | Indicates whether the selected array elements, with the current as one of them, replace the profile array in the target host profile.  | [optional] 
**ToBeDeleted** | **bool** | Indicates whether this profile is marked as to-be-deleted.  | [optional] 
**CopyEnableStatus** | **bool** | Indicates that the member variable &lt;code&gt;enabled&lt;/code&gt; of this profile will be copied from source profile to target profiles at host profile composition.  | [optional] 
**Hidden** | **bool** | Indicates whether this profile will be displayed or not.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

