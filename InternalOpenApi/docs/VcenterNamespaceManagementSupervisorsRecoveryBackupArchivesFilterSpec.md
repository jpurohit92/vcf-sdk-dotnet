# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsRecoveryBackupArchivesFilterSpec
The Vcenter.NamespaceManagement.Supervisors.Recovery.Backup.Archives.FilterSpec schema contains properties used to filter the result when listing Backup archives (see *GET /vcenter/namespace-management/supervisors/recovery/backup/archives*).  This schema was added in __vSphere API 8.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Archive** | **string** | Matches Backup archives with *Vcenter.NamespaceManagement.Supervisors.Recovery.Backup.Archives.Info.archive* equal to the specified value.  This property was added in __vSphere API 8.0.3.0__.  if missing or &#x60;null&#x60; this filter is not applied.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.supervisor.backup.Archive&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.supervisor.backup.Archive&#x60;. | [optional] 
**Usable** | **bool** | Matches Backup archives with *Vcenter.NamespaceManagement.Supervisors.Recovery.Backup.Archives.Info.usable* equal to the specified value.  This property was added in __vSphere API 8.0.3.0__.  if missing or &#x60;null&#x60; this filter is not applied. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

