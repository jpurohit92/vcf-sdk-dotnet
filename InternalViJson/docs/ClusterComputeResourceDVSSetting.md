# Vcenter.ViJson.OpenApi.Model.ClusterComputeResourceDVSSetting

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DvSwitch** | [**ManagedObjectReference**](ManagedObjectReference.md) | Managed object reference to the DVS.  Refers instance of *DistributedVirtualSwitch*.  | 
**PnicDevices** | **List&lt;string&gt;** | List of physical nics attached to the DVS.  | [optional] 
**DvPortgroupSetting** | [**List&lt;ClusterComputeResourceDVSSettingDVPortgroupToServiceMapping&gt;**](ClusterComputeResourceDVSSettingDVPortgroupToServiceMapping.md) | Describes dvportgroups on the DVS and services residing on each one.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

