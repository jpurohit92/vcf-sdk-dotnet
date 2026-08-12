# Vcenter.ViJson.OpenApi.Model.ClusterComputeResourceHostConfigurationValidation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Info** | [**List&lt;LocalizableMessage&gt;**](LocalizableMessage.md) | Describes the messages relevant to the validation result  | [optional] 
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | Host being validated.  Refers instance of *HostSystem*.  | 
**IsDvsSettingValid** | **bool** | Check if the host is attached to the DVS on right adapters.  | [optional] 
**IsVmknicSettingValid** | **bool** | Check if the adapters for services are present and on the right portgroups.  | [optional] 
**IsNtpSettingValid** | **bool** | Check if NTP is configured per specification.  | [optional] 
**IsLockdownModeValid** | **bool** | Check if lockdown mode is set per specification  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

