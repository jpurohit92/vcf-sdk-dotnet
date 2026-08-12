# Vcenter.ViJson.OpenApi.Model.HostProfileManagerCompositionValidationResultResultElement

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Target** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target host profile.  Refers instance of *Profile*.  | 
**Status** | **string** | The composition validation status.  See *HostProfileManagerCompositionValidationResultResultElementStatus_enum* for details of supported values.  | 
**Errors** | [**List&lt;LocalizableMessage&gt;**](LocalizableMessage.md) | The composition validation errors.  | [optional] 
**SourceDiffForToBeMerged** | [**HostApplyProfile**](HostApplyProfile.md) | When a selected sub profile for composition exists in both the source and target host profile, this member will contain the source side difference for the selected sub profiles.  | [optional] 
**TargetDiffForToBeMerged** | [**HostApplyProfile**](HostApplyProfile.md) | Similar to the member &lt;code&gt;sourceDiffForToBeMerged&lt;/code&gt; above but contains the target side difference.  Comparing the same configurations in these two variables will show the changes for the configurations that exist in both source and target host profile.  | [optional] 
**ToBeAdded** | [**HostApplyProfile**](HostApplyProfile.md) | The sub profiles doesn&#39;t exist in the target and will be added to the target at host profile composition.  | [optional] 
**ToBeDeleted** | [**HostApplyProfile**](HostApplyProfile.md) | The sub profiles exists in the target but not in the source and will be deleted from the target at host profile composition.  | [optional] 
**ToBeDisabled** | [**HostApplyProfile**](HostApplyProfile.md) | The sub profiles to be disabled in the target host profiles.  | [optional] 
**ToBeEnabled** | [**HostApplyProfile**](HostApplyProfile.md) | The sub profiles to be enabled in the target host profiles.  | [optional] 
**ToBeReenableCC** | [**HostApplyProfile**](HostApplyProfile.md) | The sub profile to be unset ignoring compliance check in the target host profile.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

