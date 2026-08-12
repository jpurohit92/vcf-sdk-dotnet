# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsStorageCloudNativeMaintenanceActionType
The Vcenter.NamespaceManagement.Supervisors.Storage.CloudNative.MaintenanceActionType schema contains actions to be taken when an entity enters maintenance mode.  Possible values:   - `PERMANENT_REMOVAL`: The entity is getting permanently removed. Move applications, rebuild storage on other entities before allowing to proceed.   - `ENSURE_ACCESSIBILITY`: The entity is going down temporarily for maintenance. Still need to ensure application availability and storage accessibility at least in a degraded level.   - `NO_ACTION`: Admin override to not delay or stop the entity from entering maintenance mode.   This enumeration was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

