# Vcenter.ViJson.OpenApi.Model.EsxAgentManagerMaintenanceModePolicyEnum
Deprecated as of vSphere 9.0. Please refer to vLCM Image APIs.  <code>MaintenanceModePolicy</code> defines how ESX Agent Manager is going to put into maintenance mode hosts which are part of a cluster not managed by vSphere Lifecycle Manager.  Possible values: - `singleHost`: Only a single host at a time will be put into maintenance mode. - `multipleHosts`: Hosts will be put into maintenance mode simultaneously.      If vSphere DRS   is enabled, its recommendations will be used. Otherwise, it will be   attempted to put in maintenance mode simultaneously as many host as   possible.  ***Since:*** vEAM API 7.4 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

