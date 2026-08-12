# Vcenter.ViJson.OpenApi.Model.VsanSpaceEfficiencyRatio

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OverallRatio** | **float** | The cluster level space efficiency ratio.  For vSAN ESA, it will exclude all the system overhead.  | [optional] 
**CompressionRatio** | **float** | The cluster level space efficiency ratio for compression.  This attribute specifically quantifies the space efficiency achieved through compression, without considering other efficiency features. It is only exposed when compression is enabled within the cluster state. Compression Ratio &#x3D; Space Usage Before Compression / Space Usage After Compression  | [optional] 
**DedupRatio** | **float** | The cluster level space efficiency ratio for compression.  This attribute specifically quantifies the space efficiency achieved through deduplication, without considering other efficiency features. It is only exposed when deduplication is enabled within the cluster state. Deduplication Ratio &#x3D; Space Usage Before Deduplication / Space Usage After Deduplication  | [optional] 
**DedupEnabledRatio** | **float** | The storage space reduction ratio by vSAN ESA global deduplication.  Unlike dedupRatio, this ratio only measures the objects that are eligible for global deduplication.  | [optional] 
**ThinProvisionRatio** | **float** | The storage space reduction ratio for thin provisioning in cluster.  It measures the efficiency gained by allocating storage on-demand rather than reserving the full provisioned size up front. It is calculated by total thin provisioning space / used space.  | [optional] 
**SnapshotSavingRatio** | **float** | The storage space reduction ratio by snapshots saving in cluster.  It is calculated by fully inflated snapshot capacity / actual written snapshot capacity in bytes.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

