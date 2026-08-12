# Vcenter.ViJson.OpenApi.Model.VibCannotPutHostInMaintenanceMode
Deprecated as of vSphere 9.0. Please refer to vLCM Image APIs.  A VIB module requires the host to be in maintenance mode, but the vSphere ESX Agent Manager is unable toput the host in maintenance mode.  This can happen if there are virtual machines running on the host that cannot be moved and must be stopped before the host can enter maintenance mode.  This is an active remediable issue. To remediate, the vSphere ESX Agent Manager will try again to put the host into maintenance mode. However, the vSphere ESX Agent Manager will not power off or move any virtual machines to put the host into maintenance mode. This must be done by the client.  This structure may be used only with operations rendered under `/eam`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

