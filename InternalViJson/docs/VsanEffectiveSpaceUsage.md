# Vcenter.ViJson.OpenApi.Model.VsanEffectiveSpaceUsage

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TotalUsableB** | **long** | The total usable vSAN capacity in bytes.  It&#39;s the total of free vSAN physical storage space for user workloads in the vSAN datastore, excluding all system reservations and overhead such as RAID redundancy.  | 
**FreeUsableB** | **long** | The free usable vSAN capacity in bytes.  Free usable capacity refers to the remaining portion of the total usable capacity in the vSAN datastore that is still available for user data, after subtracting the space already consumed by user workloads. The totalUsableB - freeUsableB &#x3D; used capacity.  | 
**ActualWrittenB** | **long** | The actual written vSAN capacity in bytes.  It is actual used capacity but excluding the reserved data by thick provisioning in this cluster, excluding all system reservations and overhead such as RAID redundancy.  | [optional] 
**OverReservedB** | **long** | The over reserved capacity in bytes by thick provisioning but not actually used yet in this cluster, excluding all system reservations and overhead such as RAID redundancy.  | [optional] 
**TotalProvisionB** | **long** | The total provisioned capacity in bytes in cluster.  It is aggregated by the provisioning capacity of all user objects in this cluster without taking RAID overhead into consideration. Below are the types of objects will be regarded as exceptions: 1\\. Namespace objects 2\\. Swap objects 3\\. Some other system objects like global deduplication store objects. The thin provisioning size of these objects will not be counted into the total provisioned capacity, but only the actual primary written capacity will be counted.  | [optional] 
**SnapshotSpace** | [**VsanSnapshotSpace**](VsanSnapshotSpace.md) | The snapshot space usage metrics, excluding all system reservations and overhead such as RAID redundancy.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

