# Vcenter.ViJson.OpenApi.Model.CustomizationWinOptions

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChangeSID** | **bool** | The customization process should modify the machine&#39;s security identifier (SID).  For Vista OS and greater, SID will always be modified and a value of false will generate an error.  | 
**DeleteAccounts** | **bool** | Deprecated as of VI API 2.5, this value is ignored. Removing user accounts during customization is no longer supported. To change the administrator password, set the administrator password to blank in the master vm. Sysprep will then be able to change the password to the one specified by the *CustomizationGuiUnattended.password*.  If deleteAccounts is true, then all user accounts are removed from the system as part of the customization.  Mini-setup creates a new Administrator account with a blank password.  | 
**Reboot** | **CustomizationSysprepRebootOptionEnum** | A value of type SysprepRebootOption specifying the action that should be taken after running sysprep.  Defaults to \&quot;reboot\&quot;.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

