# Vcenter.ViJson.OpenApi.Model.VmConfigFileInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Path** | **string** | The path relative to the folder path in the search results.  | 
**FriendlyName** | **string** | User friendly name.  | [optional] 
**FileSize** | **long** | The size of the file in bytes.  | [optional] 
**Modification** | **DateTime** | The last date and time the file was modified.  | [optional] 
**Owner** | **string** | The user name of the owner of the file.  | [optional] 
**ConfigVersion** | **int** |  | [optional] 
**Encryption** | [**VmConfigFileEncryptionInfo**](VmConfigFileEncryptionInfo.md) | The encryption information of the virtual machine configuration file.  If encryption was selected in VmConfigFileQueryFlags then this field is always set. Inspect the VmConfigEncryptionInfo to determine if the virtual machine configuration file is encrypted.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

