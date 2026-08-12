# Vcenter.ViJson.OpenApi.Model.CompositeHostProfileRequestType
The parameters of *HostProfileManager.CompositeHostProfile_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Source** | [**ManagedObjectReference**](ManagedObjectReference.md) | Refers instance of *Profile*.  | 
**Targets** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | Refers instances of *Profile*.  | [optional] 
**ToBeMerged** | [**HostApplyProfile**](HostApplyProfile.md) |  | [optional] 
**ToBeReplacedWith** | [**HostApplyProfile**](HostApplyProfile.md) |  | [optional] 
**ToBeDeleted** | [**HostApplyProfile**](HostApplyProfile.md) |  | [optional] 
**EnableStatusToBeCopied** | [**HostApplyProfile**](HostApplyProfile.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

