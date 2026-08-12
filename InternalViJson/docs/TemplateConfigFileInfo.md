# Vcenter.ViJson.OpenApi.Model.TemplateConfigFileInfo
This data object type describes a template virtual machine configuration file. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConfigVersion** | **int** |  | [optional] 
**Encryption** | [**VmConfigFileEncryptionInfo**](VmConfigFileEncryptionInfo.md) | The encryption information of the virtual machine configuration file.  If encryption was selected in VmConfigFileQueryFlags then this field is always set. Inspect the VmConfigEncryptionInfo to determine if the virtual machine configuration file is encrypted.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

