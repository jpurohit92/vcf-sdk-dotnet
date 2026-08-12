# Vcenter.Automation.OpenApi.Model.VcenterGuestWindowsSysprep
The Vcenter.Guest.WindowsSysprep schema provides all the settings like user details, administrator details, etc that need to applied for a windows guest operating system during customization.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GuiRunOnceCommands** | **List&lt;string&gt;** | A list of commands to run at first user logon, after customizing the guest. These commands are directly mapped to the GuiRunOnce key in the sysprep.xml answer file. These commands are transferred into the sysprep.xml file that VirtualCenter stores on the target virtual disk. For more information about performing unattended installation, check https://technet.microsoft.com/en-us/library/cc771830(v&#x3D;ws.10).aspx The commands listed here ar executed when a user logs on the first time after customization completes. The logon may be driven by *Vcenter.Guest.GuiUnattended.auto_logon* setting. These commands are directly mapped to the GuiRunOnce key in the  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, no commands are run. | [optional] 
**UserData** | [**VcenterGuestUserData**](VcenterGuestUserData.md) | Personal data pertaining to the owner of the virtual machine.  This property was added in __vSphere API 7.0.0.0__. | 
**Domain** | [**VcenterGuestDomain**](VcenterGuestDomain.md) | Information needed to join a workgroup or domain.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, the guest will not be joined to any workgroup or a domain. | [optional] 
**GuiUnattended** | [**VcenterGuestGuiUnattended**](VcenterGuestGuiUnattended.md) | Information related to unattended installation.  This property was added in __vSphere API 7.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

