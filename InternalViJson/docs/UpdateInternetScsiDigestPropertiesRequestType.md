# Vcenter.ViJson.OpenApi.Model.UpdateInternetScsiDigestPropertiesRequestType
The parameters of *HostStorageSystem.UpdateInternetScsiDigestProperties*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IScsiHbaDevice** | **string** | The device of the Internet SCSI HBA adapter.  | 
**TargetSet** | [**HostInternetScsiHbaTargetSet**](HostInternetScsiHbaTargetSet.md) | The set the targets to configure. If not provided, the settings will be applied to the host bus adapter itself.  | [optional] 
**DigestProperties** | [**HostInternetScsiHbaDigestProperties**](HostInternetScsiHbaDigestProperties.md) | The data object that represents the digest settings to set.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

