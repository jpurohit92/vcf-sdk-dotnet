# Vcenter.ViJson.OpenApi.Model.ValidateHostProfileCompositionRequestType
The parameters of *HostProfileManager.ValidateHostProfileComposition_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Source** | [**ManagedObjectReference**](ManagedObjectReference.md) | The source host profile of the configurations for composition.  Refers instance of *Profile*.  | 
**Targets** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | The array of target host profiles that the configurations composite into.  Refers instances of *Profile*.  | [optional] 
**ToBeMerged** | [**HostApplyProfile**](HostApplyProfile.md) | A *HostApplyProfile* object contains the sub profiles that will be merged from the source to the target host profiles, and all the ancestors of these sub profiles. For singleton sub profile, it will be added into a target host profile if it doesn&#39;t exist in the target; otherwise, it replaces the one in the target. The member variable *ApplyProfile.toBeMerged* of these sub profiles should have a value of &lt;code&gt;true&lt;/code&gt;. The member variables *ApplyProfile.toBeMerged* *ApplyProfile.toReplaceWith*, *ApplyProfile.toBeDeleted* of the ancestors should have a value of &lt;code&gt;false&lt;/code&gt;.  | [optional] 
**ToReplaceWith** | [**HostApplyProfile**](HostApplyProfile.md) | A *HostApplyProfile* object contains the sub profiles that will be used to replace the array in the target host profiles, and all the ancestors of these sub profiles. Similar to above except that the member variable *ApplyProfile.toReplaceWith* is turned on.  | [optional] 
**ToBeDeleted** | [**HostApplyProfile**](HostApplyProfile.md) | A *HostApplyProfile* object contains the sub profiles that will be deleted from the source **and** the target host profiles, and all the ancestors of these sub profiles. Similar to above except that the member variable *ApplyProfile.toBeDeleted* is turned on.  | [optional] 
**EnableStatusToBeCopied** | [**HostApplyProfile**](HostApplyProfile.md) | A *HostApplyProfile* object contains the sub profiles that the member variable *ApplyProfile.enabled* will be copied from the source host profile to all the target host profiles, and all the ancestors of these sub profiles. The member variable *ApplyProfile.copyEnableStatus* of these sub profiles is turned on. The member variable *ApplyProfile.copyEnableStatus* of the *ApplyProfile.copyEnableStatus* of the ancestors should have a value of &lt;code&gt;false&lt;/code&gt;.  | [optional] 
**ErrorOnly** | **bool** | Indicates that the validation result for each target don&#39;t contain the source-target difference.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

