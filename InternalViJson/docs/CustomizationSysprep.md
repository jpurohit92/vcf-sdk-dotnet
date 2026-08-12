# Vcenter.ViJson.OpenApi.Model.CustomizationSysprep

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GuiUnattended** | [**CustomizationGuiUnattended**](CustomizationGuiUnattended.md) | An object representation of the sysprep GuiUnattended key.  | 
**UserData** | [**CustomizationUserData**](CustomizationUserData.md) | An object representation of the sysprep UserData key.  | 
**GuiRunOnce** | [**CustomizationGuiRunOnce**](CustomizationGuiRunOnce.md) | An object representation of the sysprep GuiRunOnce key.  | [optional] 
**Identification** | [**CustomizationIdentification**](CustomizationIdentification.md) | An object representation of the sysprep Identification key.  | 
**LicenseFilePrintData** | [**CustomizationLicenseFilePrintData**](CustomizationLicenseFilePrintData.md) | An object representation of the sysprep LicenseFilePrintData key.  Required only for Windows 2000 Server and Windows Server 2003.  | [optional] 
**ScriptText** | **string** | The script to run before and after GOS customization.  The script must be a batch file for Windows virtual machines. For additional information, refer to &lt;a href&#x3D;\&quot;https://knowledge.broadcom.com/external/article?legacyId&#x3D;74880\&quot;target&#x3D;\&quot;_blank\&quot;&gt;Setting the customization script for virtual machines in vSphere&lt;/a&gt;.  ***Since:*** vSphere API Release 9.1.0.0  | [optional] 
**ResetPassword** | **bool** | Require local Administrators group accounts to change their password at the first logon after customization.  ***Since:*** vSphere API Release 9.1.0.0  | [optional] 
**ExtraConfig** | [**List&lt;OptionValue&gt;**](OptionValue.md) | Additional key/value pairs to support third party customization.  ***Since:*** vSphere API Release 9.1.0.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

