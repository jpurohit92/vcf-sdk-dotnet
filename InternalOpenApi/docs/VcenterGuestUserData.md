# Vcenter.Automation.OpenApi.Model.VcenterGuestUserData
The Vcenter.Guest.UserData schema specifies the personal data pertaining to the user of the Windows guest operating system. This schema maps to the UserData key in the sysprep.xml answer file. These values are transferred directly into the sysprep.xml file that VirtualCenter stores on the target virtual disk. For more detailed information about performing unattended installation, check https://technet.microsoft.com/en-us/library/cc771830(v=ws.10).aspx  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ComputerName** | [**VcenterGuestHostnameGenerator**](VcenterGuestHostnameGenerator.md) | The computer name of the (Windows) virtual machine. A computer name may contain letters (A-Z), numbers(0-9) and hyphens (-) but no spaces or periods (.). The name may not consist entirely of digits. A computer name is restricted to 15 characters in length. If the computer name is longer than 15 characters, it will be truncated to 15 characters. Check *Vcenter.Guest.HostnameGenerator* for various options.  This property was added in __vSphere API 7.0.0.0__. | 
**FullName** | **string** | Full name of the end user. Note that this is not the username but full name specified in \&quot;Firstname Lastname\&quot; format.  This property was added in __vSphere API 7.0.0.0__. | 
**Organization** | **string** | Name of the organization that owns the computer.  This property was added in __vSphere API 7.0.0.0__. | 
**ProductKey** | **string** | The product Key to use for activating Windows guest operating system.  This property was added in __vSphere API 7.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

