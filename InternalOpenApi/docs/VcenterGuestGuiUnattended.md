# Vcenter.Automation.OpenApi.Model.VcenterGuestGuiUnattended
The Vcenter.Guest.GuiUnattended schema maps to the GuiUnattended key in the sysprep.xml answer file. These values are plugged directly into the sysprep.xml file that VirtualCenter stores on the target virtual disk. For more detailed information about performing unattended installations, check https://technet.microsoft.com/en-us/library/cc771830(v=ws.10).aspx  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AutoLogon** | **bool** | Flag to determine whether or not the machine automatically logs on as Administrator. See the *Vcenter.Guest.GuiUnattended.password* property. If *Vcenter.Guest.GuiUnattended.auto_logon* flag is set, then *Vcenter.Guest.GuiUnattended.password* must not be missing or &#x60;null&#x60; or the guest customization will fail.  This property was added in __vSphere API 7.0.0.0__. | 
**AutoLogonCount** | **long** | If the *Vcenter.Guest.GuiUnattended.auto_logon* flag is set, then this property specifies the number of times the machine should automatically log on as Administrator. Generally it should be 1, but if the setup requires a number of reboots, you may want to increase it. This number may be determined by the list of commands.  This property was added in __vSphere API 7.0.0.0__. | 
**Password** | **string** | The new administrator password for the machine. To specify that the password should be set to blank (that is, no password), leave it unset.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, blank password will be used. | [optional] 
**VarTimeZone** | **long** | The time zone index for the virtual machine. Numbers correspond to time zones at https://support.microsoft.com/en-us/help/973627/microsoft-time-zone-index-values  This property was added in __vSphere API 7.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

