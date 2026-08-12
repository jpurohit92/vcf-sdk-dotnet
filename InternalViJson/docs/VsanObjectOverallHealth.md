# Vcenter.ViJson.OpenApi.Model.VsanObjectOverallHealth

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ObjectHealthDetail** | [**List&lt;VsanObjectHealth&gt;**](VsanObjectHealth.md) | The object health list each of which includes the health status, the number of objects on this health status and the object UUID list.  | [optional] 
**ObjectsComplianceDetail** | [**List&lt;VsanStorageComplianceResult&gt;**](VsanStorageComplianceResult.md) | The vSAN objects profile compliance check result  | [optional] 
**ObjectVersionCompliance** | **bool** | True to indicate all of the objects have compliant object version with the latest supported vSAN disk format.  The latest vSAN disk format version should be version 4 and the vSAN disk upgrade is needed when this flag is false  | [optional] 
**ObjectFormatChangeRequiredUuids** | **List&lt;string&gt;** | The vSAN objects which need object layout format change to get capacity improvement  | [optional] 
**ObjectsRelayoutBytes** | **long** | The total bytes for objects need relayout  | [optional] 
**GlobalDedupStoreHealth** | **string** | The global dedup store health that is value of the enum type vim.host.VsanObjectHealthState.  Global dedup store contains some hash objects and chunk objects, and the global dedup store health is an aggregation of each hash and chunk object health. Health will always pick the most serious hash or chunk object health as the global dedup store health.  | [optional] 
**ObjectStats** | [**VsanHealthObjectStats**](VsanHealthObjectStats.md) | The vSAN health object statistics.  See also *VsanHealthObjectStats*.  | [optional] 
**VsanObjectsForObjectStoreVolumes** | **List&lt;string&gt;** | A list of backing vSAN object UUIDs for object store volumes.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

