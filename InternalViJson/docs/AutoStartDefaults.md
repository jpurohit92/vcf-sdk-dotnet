# Vcenter.ViJson.OpenApi.Model.AutoStartDefaults

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **bool** | Indicates whether or not auto-start manager is enabled.  | [optional] 
**StartDelay** | **int** | System-default autoStart delay in seconds.  The default is 120 seconds.  | [optional] 
**StopDelay** | **int** | System-default autoStop delay in seconds.  The default is 120 seconds.  | [optional] 
**WaitForHeartbeat** | **bool** | System-default waitForHeartbeat setting.  | [optional] 
**StopAction** | **string** | System-default power-off action.  Used if the stopAction string in the AutoPowerInfo object for a particular machine is set to systemDefault. If stopAction and startAction for a virtual machine are both set to none, that virtual machine is removed from the AutoStart sequence.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

