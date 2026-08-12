# Vcenter.ViJson.OpenApi.Model.ChangeLockdownModeRequestType
The parameters of *HostAccessManager.ChangeLockdownMode*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Mode** | **HostLockdownModeEnum** | The new desired lockdown mode.  If this is the same as the current lockdown mode state, the operation will silently succeed and nothing will be changed.  If this is *lockdownDisabled* then lockdown mode will be disabled and the system will start service DCUI if it is not running.  If this is *lockdownNormal* then lockdown mode will be enabled and the system will start service DCUI if it is not running.  If this is *lockdownStrict* then lockdown mode will be enabled and the system will stop service DCUI if it is running.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

