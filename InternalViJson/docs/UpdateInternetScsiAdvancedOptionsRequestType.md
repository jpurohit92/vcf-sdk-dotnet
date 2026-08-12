# Vcenter.ViJson.OpenApi.Model.UpdateInternetScsiAdvancedOptionsRequestType
The parameters of *HostStorageSystem.UpdateInternetScsiAdvancedOptions*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IScsiHbaDevice** | **string** | The device of the Internet SCSI HBA adapter.  | 
**TargetSet** | [**HostInternetScsiHbaTargetSet**](HostInternetScsiHbaTargetSet.md) | The set the targets to configure. If not provided, the settings will be applied to the host bus adapter itself.  | [optional] 
**Options** | [**List&lt;HostInternetScsiHbaParamValue&gt;**](HostInternetScsiHbaParamValue.md) | The list of options to set.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

