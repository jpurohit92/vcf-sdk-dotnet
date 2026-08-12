# Vcenter.ViJson.OpenApi.Model.ApplyHostConfigRequestType
The parameters of *HostProfileManager.ApplyHostConfig_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | Host to be updated. User must have sufficient credentials and privileges to satisfy the contents of the &lt;code&gt;configSpec&lt;/code&gt;.  Refers instance of *HostSystem*.  | 
**ConfigSpec** | [**HostConfigSpec**](HostConfigSpec.md) | Set of configuration changes to be applied to the host. The changes are returned by the *HostProfile*.*HostProfile.ExecuteHostProfile* method in the *ProfileExecuteResult*.*ProfileExecuteResult.configSpec* property.  | 
**UserInput** | [**List&lt;ProfileDeferredPolicyOptionParameter&gt;**](ProfileDeferredPolicyOptionParameter.md) | Additional host-specific data to be applied to the host. This data is the complete list of deferred parameters verified by the *HostProfile*.*HostProfile.ExecuteHostProfile* method, contained in the *ProfileExecuteResult* object returned by the method.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

