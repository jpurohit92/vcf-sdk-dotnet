# Vcenter.ViJson.OpenApi.Model.VmRequiresHostOutOfMaintenanceMode
An agent virtual machine is expected to be deployed on a host, but the agent virtual machine cannot be deployed because the host is in Maintenance Mode.  This is an active remediable issue. To remediate, vSphere ESX Agent Manager takes the host out of Maintenance Mode and deploys the agent virtual machine.  Resolving this issue in vSphere Lifecycle Manager environment will be no-op. In those cases user must take the host out of Maintenance Mode manually or wait vSphere Lifecycle Manager cluster remediation to complete (if any).  This structure may be used only with operations rendered under `/eam`.  ***Since:*** vEAM API 7.2 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

