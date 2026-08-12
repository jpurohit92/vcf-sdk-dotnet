# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsStorageCloudNativeResourceChecksCreateSpec
The Vcenter.NamespaceManagement.Supervisors.Storage.CloudNative.ResourceChecks.CreateSpec schema contains the specification required to perform the resource check.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Operation** | **string** | The operation for which resource check is performed.  Possible values:   - &#x60;ENTER_MAINTENANCE_MODE&#x60;: The resource check for host enter maintenance mode operation.   For more information see: *Vcenter.NamespaceManagement.Supervisors.Storage.CloudNative.ResourceChecks.OperationType*.  This property was added in __vSphere API 9.1.0.0__. | 
**Host** | **string** | Host for which the resource check operation is performed. For host enter maintenance mode operation, the host managed object ID is required.  This property was added in __vSphere API 9.1.0.0__.  This property is optional and it is only relevant when the value of operation is *Vcenter.NamespaceManagement.Supervisors.Storage.CloudNative.ResourceChecks.OperationType.ENTER_MAINTENANCE_MODE*.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;HostSystem&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;HostSystem&#x60;. | [optional] 
**Action** | **string** | The action type of maintenance mode operation for which resource check is performed.  Possible values:   - &#x60;PERMANENT_REMOVAL&#x60;: The entity is getting permanently removed. Move applications, rebuild storage on other entities before allowing to proceed.   - &#x60;ENSURE_ACCESSIBILITY&#x60;: The entity is going down temporarily for maintenance. Still need to ensure application availability and storage accessibility at least in a degraded level.   - &#x60;NO_ACTION&#x60;: Admin override to not delay or stop the entity from entering maintenance mode.   For more information see: *Vcenter.NamespaceManagement.Supervisors.Storage.CloudNative.MaintenanceActionType*.  This property was added in __vSphere API 9.1.0.0__.  This should be set only for enter maintenance mode host operation. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

