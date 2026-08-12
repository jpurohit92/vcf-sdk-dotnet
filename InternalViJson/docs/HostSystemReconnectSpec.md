# Vcenter.ViJson.OpenApi.Model.HostSystemReconnectSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SyncState** | **bool** | This flag should be set if on a host reconnect, state such as virtual machine state in vCenter Server e.g.  the virtual machine inventory and autostart rules, has to be propagated to the host. Any virtual machines that may have been unregistered or orphaned will be reregistered according to the vCenter Server inventory. Any autostart rules that may have changed on the host will be similarly restored. This flag is primarily intended for stateless hosts to enable vCenter Server to resync these hosts after a reboot.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

