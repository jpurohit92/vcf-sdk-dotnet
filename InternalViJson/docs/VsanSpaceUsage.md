# Vcenter.ViJson.OpenApi.Model.VsanSpaceUsage

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TotalCapacityB** | **long** | The total vSAN capacity in byte, which is the total used and free capacity combined.  It&#39;s the total of physical space which can be use for writing data including any of user data, metadata and the overhead data.  | 
**FreeCapacityB** | **long** | The free vSAN capacity in byte.  It&#39;s the total of free vSAN physical space which can be used for writing data including any of user data, metadata and the overhead data.  | [optional] 
**SpaceOverview** | [**VsanObjectSpaceSummary**](VsanObjectSpaceSummary.md) | The vSAN space usage overview including the vSAN physically written capacity, the reserved and over-reserved capacity and the total used capacity.  It shares the same data structure as the per vSAN object type space usage summary VsanObjectSpaceSummary without setting the object type.  | [optional] 
**SpaceDetail** | [**VsanSpaceUsageDetailResult**](VsanSpaceUsageDetailResult.md) | The vSAN space usage detail by breakdown the usage into different vSAN object type.  | [optional] 
**EfficientCapacity** | [**VimVsanDataEfficiencyCapacityState**](VimVsanDataEfficiencyCapacityState.md) | The vSAN efficient capacity breakdown details when the vSAN cluster enables data efficiency.  | [optional] 
**WhatifCapacities** | [**List&lt;VsanWhatifCapacity&gt;**](VsanWhatifCapacity.md) | The vSAN capacity details if all objects are stored with the specified storage policy.  | [optional] 
**UncommittedB** | **long** | Total additional storage space, in bytes, potentially used by all vSAN objects except for the virtual machine swap objects and namespace objects on this vSAN datastore.  It can be retrieved through *VsanSpaceReportSystem.VsanQuerySpaceUsage* by specifying whatifCapacityOnly as False.  | [optional] 
**CapacityHealthThreshold** | [**VsanHealthThreshold**](VsanHealthThreshold.md) | Indicates the yellow or red threshold, in bytes, for capacity usage based on current cluster capacityReservationInfo.  | [optional] 
**SpaceEfficiencyRatio** | [**VsanSpaceEfficiencyRatio**](VsanSpaceEfficiencyRatio.md) | Indicates the vSAN space efficiency ratio, it exists only when vSAN efficiency feature is enabled, including global deduplication and compression.  ***Since:*** 8.0.0.4  | [optional] 
**EffectiveSpaceUsage** | [**VsanEffectiveSpaceUsage**](VsanEffectiveSpaceUsage.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

