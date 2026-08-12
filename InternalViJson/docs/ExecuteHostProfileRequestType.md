# Vcenter.ViJson.OpenApi.Model.ExecuteHostProfileRequestType
The parameters of *HostProfile.ExecuteHostProfile*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | Host on which to execute the profile. The host does not have to be associated with the profile.  Refers instance of *HostSystem*.  | 
**DeferredParam** | [**List&lt;ProfileDeferredPolicyOptionParameter&gt;**](ProfileDeferredPolicyOptionParameter.md) | Additional configuration data to be applied to the host. This should contain all of the host-specific data, including data from from previous calls to the method.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

