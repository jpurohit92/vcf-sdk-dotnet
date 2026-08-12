# Vcenter.ViJson.OpenApi.Model.UpdateInternetScsiAuthenticationPropertiesRequestType
The parameters of *HostStorageSystem.UpdateInternetScsiAuthenticationProperties*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IScsiHbaDevice** | **string** | The device of the Internet SCSI HBA adapter. associated with the target.  | 
**AuthenticationProperties** | [**HostInternetScsiHbaAuthenticationProperties**](HostInternetScsiHbaAuthenticationProperties.md) | The data object that represents the authentication settings to set.  | 
**TargetSet** | [**HostInternetScsiHbaTargetSet**](HostInternetScsiHbaTargetSet.md) | The set the targets to configure. Optional, when omitted will configure the authentication properties for the adapter instead.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

