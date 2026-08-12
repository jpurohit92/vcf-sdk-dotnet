# Vcenter.ViJson.OpenApi.Model.VsanSiteMaintenanceInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FaultDomainName** | **string** | User friendly name of the fault domain.  | 
**State** | **string** | The maintenance state of the fault domain.  See also *VsanSiteMaintenanceState_enum*.  | 
**TrackingTask** | [**ManagedObjectReference**](ManagedObjectReference.md) | A task that is executing the fault domain maintenance action.  This will be unset if there is no on-going task.  Refers instance of *Task*.  | [optional] 
**HostStatus** | [**List&lt;VsanHostSiteMaintenanceStatus&gt;**](VsanHostSiteMaintenanceStatus.md) | Fault domain maintenance status of connected hosts in the site.  If no host is connected, this field will be unset.  | [optional] 
**StatusUpdateTime** | **long** | Represents the timestamp of the most recent fault domain maintenance status update.  If the site was never in fault domain maintenance mode, it will be left as unset. Unit in nanosecond.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

