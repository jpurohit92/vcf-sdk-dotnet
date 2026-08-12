# Vcenter.ViJson.OpenApi.Model.CnsVsanFileShareBackingDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BackingFileId** | **string** | At the time of creation this field would identify the existing file share that should be used to back the container volume.     This field is optional and when not specified, a new file share will be created to back the volume.    When this field is present, capacityInMb and storage policy fields will be ignored.  | [optional] 
**Name** | **string** | vSAN file share name.     This field is ignored while creating the volume. However, this field is populated with the name of the vSAN file share while returning it in Query APIs.  | [optional] 
**AccessPoints** | [**List&lt;KeyValue&gt;**](KeyValue.md) | A key-value pair indicating the access points for the file share.  The key of an access point is the type of the protocol, and the value of the access point is the connection string for accessing the file share.    The supported type of protocol string is NFSv4.1/NFSv3.    This field is ignored while creating the volume. However, this field is populated with the access points of the file share while returning it in Query APIs.  | [optional] 
**Permission** | [**List&lt;VsanFileShareNetPermission&gt;**](VsanFileShareNetPermission.md) | The permission parameters set for this file share.  If this field is not set, for NFS then no user can access this file share.    This field is ignored from *CnsVolumeCreateSpec* while creating the volume. However, this field is set in the query APIs.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

