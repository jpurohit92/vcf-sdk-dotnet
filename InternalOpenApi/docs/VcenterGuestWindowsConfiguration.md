# Vcenter.Automation.OpenApi.Model.VcenterGuestWindowsConfiguration
The Vcenter.Guest.WindowsConfiguration schema specifies the settings for customizing a windows guest operating system.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Reboot** | **string** | A value specifying the action that should be taken after customization.  Possible values:   - &#x60;REBOOT&#x60;: Reboot the guest after customization.   - &#x60;NO_REBOOT&#x60;: Take no action. Leave the guest OS running after customization. This option can be used to look at values for debugging purposes.   - &#x60;SHUTDOWN&#x60;: Shutdown the guest after customization.   For more information see: *Vcenter.Guest.WindowsConfiguration.RebootOption*.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, the *Vcenter.Guest.WindowsConfiguration.RebootOption.REBOOT* option will be chosen. | [optional] 
**Sysprep** | [**VcenterGuestWindowsSysprep**](VcenterGuestWindowsSysprep.md) | Customization settings like user details, administrator details, etc for the windows guest operating system. Exactly one of sysprep or sysprep_xml must be specified.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, sysprep settings will not be applied to the windows guest operating system. | [optional] 
**SysprepXml** | **string** | All settings specified in a XML format. This is the content of a typical answer.xml file that is used by System administrators during the Windows image customization. Check https://docs.microsoft.com/en-us/windows-hardware/manufacture/desktop/update-windows-settings-and-scripts-create-your-own-answer-file-sxs Exactly one of sysprep or sysprep_xml must be specified.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, sysprep settings will not be applied to the windows guest operating system. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

