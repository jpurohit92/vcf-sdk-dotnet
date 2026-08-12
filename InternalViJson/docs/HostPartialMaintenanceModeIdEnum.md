# Vcenter.ViJson.OpenApi.Model.HostPartialMaintenanceModeIdEnum
The following enum describes some common kinds of partial maintenance modes, as well as their special semantics.  Possible values: - `quickPatchPartialMM`: When the host is in the quick patch partial maintenance mode, it is safe to   perform a quick patch.      When the host is in this partial maintenance mode, any virtual machines   and/or pods placed on it will continue to run but operations which may   lead to new workloads starting on the host such as power on or incoming   vmotions may be blocked.   It is generally unsafe to reboot the host in this state.      ***Since:*** vSphere API Release 8.0.3.0  ***Since:*** vSphere API Release 8.0.3.0 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

