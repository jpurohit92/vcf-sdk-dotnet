# Vcenter.ViJson.OpenApi.Model.StateAlarmExpression

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Operator** | **StateAlarmOperatorEnum** | The operation to be tested on the target state.  | 
**Type** | **string** | Name of the object type containing the property.  | 
**StatePath** | **string** | Path of the state property.  The supported values: - for vim.VirtualMachine type: - runtime.powerState or summary.quickStats.guestHeartbeatStatus - for vim.HostSystem type: runtime.connectionState  | 
**Yellow** | **string** | Whether or not to test for a yellow condition.  If this property is not set, do not calculate yellow status.  | [optional] 
**Red** | **string** | Whether or not to test for a red condition.  If this property is not set, do not calculate red status.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

