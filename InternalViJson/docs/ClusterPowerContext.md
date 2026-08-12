# Vcenter.ViJson.OpenApi.Model.ClusterPowerContext

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CurrentClusterPowerStatus** | **string** | The current ClusterPowerStatus.  See also *ClusterPowerStatus_enum*.  | 
**OrderedClusterPowerStatus** | **List&lt;string&gt;** | A full list of ClusterPowerStatus with its corresponding executing order to final status.  It contains only the relevant actions based on the target ClusterPowerStatus.  See also *ClusterPowerStatus_enum*.  | [optional] 
**TrackingTask** | [**ManagedObjectReference**](ManagedObjectReference.md) | A task that is executing the power action.  None is returned if there is no on-going task  Refers instance of *Task*.  | [optional] 
**LastErrorMessage** | [**LocalizableMessage**](LocalizableMessage.md) | The description of error message if the previous task failed.  | [optional] 
**LastErrorMOs** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | The MO list that causes the previous task to fail.  i.e. if previous task failed because of having not powered-off VMs during power off cluster, the list contains some of the not powered-off VMs.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

