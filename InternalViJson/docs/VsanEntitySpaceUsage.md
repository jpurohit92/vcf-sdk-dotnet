# Vcenter.ViJson.OpenApi.Model.VsanEntitySpaceUsage

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EntityId** | **string** | The vSAN object entity ID.  For the entity like virtual machine, it&#39;s the managed object ID like &#39;vm-1&#39;.  | [optional] 
**SpaceUsageByObjectType** | [**List&lt;VsanObjectSpaceSummary&gt;**](VsanObjectSpaceSummary.md) | The vSAN space usage breakdown by object type for all of vSAN objects belonging to the entity.  | [optional] 
**TotalCapacityB** | **long** | The total capacity in byte, which is the total used and free capacity combined.  It&#39;s the total of physical space which can be use for writing data including any of user data, metadata and the overhead data.  | [optional] 
**FreeCapacityB** | **long** | The free capacity in byte.  It&#39;s the total of free physical space which can be used for writing data including any of user data, metadata and the overhead data.  | [optional] 
**EfficientCapacity** | [**VimVsanDataEfficiencyCapacityState**](VimVsanDataEfficiencyCapacityState.md) | The efficient capacity breakdown details when the vSAN cluster enables data efficiency.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

