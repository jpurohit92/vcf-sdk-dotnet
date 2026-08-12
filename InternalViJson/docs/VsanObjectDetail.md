# Vcenter.ViJson.OpenApi.Model.VsanObjectDetail

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uuid** | **string** | vSAN object uuid.  Its format is like &#39;e3d10064-ae3c-9323-568d-b02628350470&#39;.  | 
**ObjectPath** | **string** | Vmdk descriptor file that points to the object running point.  It is a full path in the format like \&quot;/vmfs/volume/vsan:522116b0018397a0-faf6eef653793842/2e661d64-20a3-afb9-80f6-e4434ba16432/foo.vmdk\&quot; It is set when the field includeDescriptorPath of *VsanSnapshotQuerySpec* is True.  | [optional] 
**Snapshots** | [**List&lt;VsanSnapshotDetail&gt;**](VsanSnapshotDetail.md) | A list of snapshots information of vSAN object.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

