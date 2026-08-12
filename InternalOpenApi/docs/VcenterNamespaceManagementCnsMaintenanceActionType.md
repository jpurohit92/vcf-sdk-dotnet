# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementCnsMaintenanceActionType
The Vcenter.NamespaceManagement.Cns.MaintenanceActionType schema contains actions to be taken when an entity enters maintenance mode.  Possible values:   - `PermanentRemoval`: The entity is getting permanently removed. Move applications, rebuild storage on other entities before allowing to proceed.   - `EnsureAccessibility`: The entity is going down temporarily for maintenance. Still need to ensure application availability and storage accessibility at least in a degraded level.   - `NoAction`: Admin override to not delay or stop the entity from entering maintenance mode. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

