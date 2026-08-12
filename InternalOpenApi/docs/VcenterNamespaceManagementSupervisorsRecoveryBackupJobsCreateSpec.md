# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsRecoveryBackupJobsCreateSpec
The Vcenter.NamespaceManagement.Supervisors.Recovery.Backup.Jobs.CreateSpec schema contains inputs to be specified for *POST /vcenter/namespace-management/supervisors/{supervisor}/recovery/backup/jobs*.  This schema was added in __vSphere API 8.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Comment** | **string** | Comment to help identify resulting Backup archive.  This property was added in __vSphere API 8.0.3.0__.  If missing or &#x60;null&#x60; comment will be empty. | [optional] 
**IgnoreHealthCheckFailure** | **bool** | Ignore Supervisor health check failure when taking Supervisor backup. Supervisor is considered unhealthy if either *Vcenter.NamespaceManagement.Supervisors.Summary.Info.config_status* or *Vcenter.NamespaceManagement.Supervisors.Summary.Info.kubernetes_status* value, as returned by *GET /vcenter/namespace-management/supervisors/{supervisor}/summary* operation is set to ERROR.  This property was added in __vSphere API 8.0.3.0__.  if missing or &#x60;null&#x60; or set to &#x60;false&#x60;, health check failure of Supervisor will not be ignored and will result in *POST /vcenter/namespace-management/supervisors/{supervisor}/recovery/backup/jobs* operation to report failure. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

