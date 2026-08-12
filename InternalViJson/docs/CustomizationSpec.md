# Vcenter.ViJson.OpenApi.Model.CustomizationSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Options** | [**CustomizationOptions**](CustomizationOptions.md) | Optional operations (either LinuxOptions or WinOptions).  | [optional] 
**Identity** | [**CustomizationIdentitySettings**](CustomizationIdentitySettings.md) | Network identity and settings, similar to Microsoft&#39;s Sysprep tool.  This is a Sysprep, LinuxPrep, WindowsFlexPrep, LinuxFlexPrep, CloudinitPrep or SysprepText object.  | 
**GlobalIPSettings** | [**CustomizationGlobalIPSettings**](CustomizationGlobalIPSettings.md) | Global IP settings constitute the IP settings that are not specific to a particular virtual network adapter.  | 
**NicSettingMap** | [**List&lt;CustomizationAdapterMapping&gt;**](CustomizationAdapterMapping.md) | IP settings that are specific to a particular virtual network adapter.  The AdapterMapping object maps a network adapter&#39;s MAC address to its Adapter settings object. May be empty if there are no network adapters, else should match number of network adapters in the VM.  | [optional] 
**EncryptionKey** | **List&lt;int&gt;** | Byte array containing the public key used to encrypt any passwords stored in the specification.  Both the client and the server can use this to determine if stored passwords can be decrypted by the server or if the passwords need to be re-entered and re-encrypted before the specification can be used.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

