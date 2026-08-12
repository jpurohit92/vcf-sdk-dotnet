# Vcenter.ViJson.OpenApi.Model.EamObjectRuntimeInfoGoalStateEnum
Deprecated as of vSphere 9.0. Please refer to vLCM APIs.  The <code>GoalState</code> enumeration defines the goal of the entity.  Possible values: - `enabled`: The entity should be fully deployed and active.      If the entity is an   *Agency*, it should install VIBs and deploy and power on all agent   virtual machines. If the entity is an *Agent*, its VIB should be installed and its   agent virtual machine should be deployed and powered on. - `disabled`: The entity should be fully deployed but inactive.      f the entity is an   *Agency*, the behavior is similar to the <code>enabled</code> goal state, but   agents are not powered on (if they have been powered on they are powered   off). - `uninstalled`: The entity should be completely removed from the vCenter Server.      If the entity is an   *Agency*, no more VIBs or agent virtual machines are deployed. All installed VIBs   installed by the *Agency* are uninstalled and any deployed agent virtual machines   are powered off (if they have been powered on) and deleted.   If the entity is an *Agent*, its VIB is uninstalled and the virtual machine is   powered off and deleted. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

