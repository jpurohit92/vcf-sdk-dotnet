# Vcenter.ViJson.OpenApi.Model.VirtualMachineMessage

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique identifier for this particular message.  This field is a key for looking up format strings in the locmsg catalog.  | 
**Argument** | [**List&lt;Any&gt;**](Any.md) | Substitution arguments for variables in the localized message.  Substitution variables in the format string identified by *VirtualMachineMessage.id* are 1-based indexes into this array. Substitution variable {1} corresponds to argument\\[0\\], etc.  | [optional] 
**Text** | **string** | Text in session locale.  Use *SessionManager*.*SessionManager.SetLocale* to change the session locale.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

