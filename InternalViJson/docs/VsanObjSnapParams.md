# Vcenter.ViJson.OpenApi.Model.VsanObjSnapParams

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uuid** | **string** | The UUID of vSAN object.  Its format is like \&quot;e3d10064-ae3c-9323-568d-b02628350470\&quot;  | 
**Creator** | **string** | It indicates snapshots created by the specified creator.  See also *VsanSnapshotCreator_enum*.  | [optional] 
**SnapshotType** | **string** | Type of the snapshot.  See also *VsanSnapshotType_enum*.  | [optional] 
**Cookie** | **string** | A cookie that is provided when creating the snapshot, which is in UUID format, like \&quot;e3d10064-ae3c-9323-568d-b02628350470\&quot;.  If such a data is provided in snapshot creation, it must also be provided when deleting the snapshot.  | [optional] 
**ImmutableTag** | **string** | An immutable tag that is provided when creating immutable snapshot on vSAN ESA, which should be used together with cookie.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

