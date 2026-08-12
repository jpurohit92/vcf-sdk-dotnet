# Vcenter.ViJson.OpenApi.Model.HostInMaintenanceMode
An agent virtual machine operation is expected to be initiated on host, but the agent virtual machine operation has not been initiated.  The reason is that the host is in maintenance mode.  This is an active remediable issue. To remediate, vSphere ESX Agent Manager takes the host out of maintenance mode and initiates the agent virtual machine operation.  Resolving this issue in vSphere Lifecycle Manager environment will be no-op. In those cases user must take the host out of Maintenance Mode manually or wait vSphere Lifecycle Manager cluster remediation to complete (if any).  This structure may be used only with operations rendered under `/eam`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

