# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsConditionsConditionGroupStatus
The Vcenter.NamespaceManagement.Supervisors.Conditions.ConditionGroup.Status schema represents the overall status of the condition group.  Possible values:   - `SUCCEEDED`: All conditions executed successfully.   - `RUNNING`: One or more conditions part of this condition group are in the running state and none of the other conditions are in *Vcenter.NamespaceManagement.Supervisors.Conditions.ConditionGroup.Status.ERROR* or *Vcenter.NamespaceManagement.Supervisors.Conditions.ConditionGroup.Status.WARNING* state.   - `WARNING`: One or more conditions part of this condition group are in warning state and none of the other conditions are in *Vcenter.NamespaceManagement.Supervisors.Conditions.ConditionGroup.Status.ERROR* state.   - `ERROR`: One or more conditions are in the error state.   - `UNKNOWN`: Indicates the status of one or more conditions part of this condition group can not be determined. Condition group status will be set to {#member UNKNOWN}, if all conditions are in unknown state or there is at least one condition in unknown state and all others are in *Vcenter.NamespaceManagement.Supervisors.Conditions.ConditionGroup.Status.SUCCEEDED* state.   This enumeration was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

