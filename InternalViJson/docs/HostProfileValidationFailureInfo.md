# Vcenter.ViJson.OpenApi.Model.HostProfileValidationFailureInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of host profile to be validated.  | 
**Annotation** | **string** | Host profile annotation at update.  | 
**UpdateType** | **string** | Host profile update type.  See the enumerate class &lt;code&gt;UpdateType&lt;/code&gt; above for the valid values.  | 
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | The host where the host profile is updated from.  Refers instance of *HostSystem*.  | [optional] 
**ApplyProfile** | [**HostApplyProfile**](HostApplyProfile.md) | The host configuration after validation.  | [optional] 
**Failures** | [**List&lt;ProfileUpdateFailedUpdateFailure&gt;**](ProfileUpdateFailedUpdateFailure.md) | List of failures in the host profile configuration.  | [optional] 
**Faults** | [**List&lt;MethodFault&gt;**](MethodFault.md) | The &lt;code&gt;MethodFault&lt;/code&gt;s happened at validation.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

