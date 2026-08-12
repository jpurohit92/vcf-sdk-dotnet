# Vcenter.Automation.OpenApi.Model.VcenterHostPowerState
The Vcenter.Host.PowerState enumerated type defines the power states of a host.  Possible values:   - `POWERED_ON`: The host is powered on. A host that is entering standby mode is also in this state.   - `POWERED_OFF`: The host was specifically powered off by the user through vCenter server. This state is not a certain state, because after vCenter server issues the command to power off the host, the host might crash, or kill all the processes but fail to power off.   - `STANDBY`: The host was specifically put in standby mode, either explicitly by the user, or automatically by DPM. This state is not a certain state, because after VirtualCenter issues the command to put the host in standby state, the host might crash, or kill all the processes but fail to enter standby mode. A host that is exiting standby mode is also in this state. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

