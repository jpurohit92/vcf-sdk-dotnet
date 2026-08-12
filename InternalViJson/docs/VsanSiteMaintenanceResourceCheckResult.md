# Vcenter.ViJson.OpenApi.Model.VsanSiteMaintenanceResourceCheckResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VmToMigrate** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | List of VM Managed object IDs that will be migrated after the query operations are performed.  | [optional] 
**VmToPowerOffInfo** | [**List&lt;VsanSiteMaintenanceVMPowerOffInfo&gt;**](VsanSiteMaintenanceVMPowerOffInfo.md) | List of VM to power off information that will be powered off after the query operations are performed, including the VM Managed object IDs and the reason for powering off.  | [optional] 
**CheckDetails** | [**List&lt;VsanSiteMaintenancePrecheckDetail&gt;**](VsanSiteMaintenancePrecheckDetail.md) | Represents the specific checks and their results for fault domain maintenance.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

