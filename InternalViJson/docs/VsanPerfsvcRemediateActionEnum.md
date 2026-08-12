# Vcenter.ViJson.OpenApi.Model.VsanPerfsvcRemediateActionEnum
Remediate action type.  When vSAN cluster remediate, vSAN will check the performance service configuration and performance service status. If the vSAN performance service configuration is enable but the vSAN performance service is not running, it will return \"enable\" to remediate vSAN performance service. If the vSAN performance service configuration is disable but the vSAN performance service is not running, it will return \"disable\" to remediate vSAN performance service. If the vSAN performance service configuration is enable, the vSAN performance service is running, but the profile of performance service is not match the configuration, it will return \"update\\_profile\" to remediate vSAN performance service. Others will return \"no\\_action\" which means no need to remediate vSAN performance service. Valid types are:  Possible values: - `enable`: remediate action is create stats object. - `disable`: remediate action is delete stats object. - `update_profile`: remediate action is update stats object policy. - `no_action`: remediate action will do no action. - `PerfsvcRemediateAction_Unknown` 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

