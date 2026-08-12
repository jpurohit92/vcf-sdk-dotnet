# Vcenter.ViJson.OpenApi.Model.VsanSnapshotQuerySpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DatastoreUuid** | **string** | The vSAN datatore container ID.  This can be found in *DatastoreInfo.containerId*, such as \&quot;522116b0018397a0-faf6eef653793842\&quot;  | 
**ObjectUuids** | **List&lt;string&gt;** | A list of object uuids to query snapshots.  Object uuid is in the format like \&quot;e3d10064-ae3c-9323-568d-b02628350470\&quot;.  | [optional] 
**SnapshotType** | **string** | If set, snapshots of the specified type will be returned.  See also *VsanSnapshotType_enum*.  | [optional] 
**Creator** | **string** | If set, snapshots created by the specified creator will be returned.  See also *VsanSnapshotCreator_enum*.  | [optional] 
**IncludeDescriptorPath** | **bool** | If set to True, the vmdk descriptor file path will be returned.  | [optional] 
**SnapshotTagMask** | **int** | The bitmap mask that indicates which snapshot tags are queried.  Each bit represents a snapshot tag type, a value of 1 means the corresponding tag type should be included in the query. Current only one tag type is supported. \\- Bit 0 (The Least Significant Bit): Immutable tag. \\- Bit 1 and above: reserved for future use. If the queried tag type doesn&#39;t exist on the snapshot, it will not be returned in *VsanSnapshotDetail*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

