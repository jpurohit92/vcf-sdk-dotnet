# Vcenter.ViJson.OpenApi.Model.VsanSnapshotDetail

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SnapshotId** | **int** | vSAN ESA Snapshot ID, such as 1.  | 
**SnapshotType** | **string** | Type of the snapshot.  See also *VsanSnapshotType_enum*.  | 
**SnapshotPath** | **string** | Vmdk descriptor file path of the snapshot.  It is a full path in the format like \&quot;/vmfs/volume/vsan:522116b0018397a0-faf6eef653793842/2e661d64-20a3-afb9-80f6-e4434ba16432/foo-001.vmdk\&quot; It is set when the field includeDescriptorPath of *VsanSnapshotQuerySpec* is True.  | [optional] 
**SnapshotTagsInfo** | [**List&lt;KeyValue&gt;**](KeyValue.md) | The tag information related to a snapshot on vSAN ESA, requested through the snapshotTagMask in *VsanSnapshotQuerySpec*.  The key part is the snapshot tag type string. Currently only one tag type \&quot;immutable\\_tag\&quot; is supported. The value part is the value string of snapshot tag.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

