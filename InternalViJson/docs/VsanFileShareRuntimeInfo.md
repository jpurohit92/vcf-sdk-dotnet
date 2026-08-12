# Vcenter.ViJson.OpenApi.Model.VsanFileShareRuntimeInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UsedCapacity** | **long** | Used capacity in byte for this share.  | [optional] 
**Hostname** | **string** | The name of the host that currently owns the file share.  | [optional] 
**Address** | **string** | The address of the file server serving this file share.  | [optional] 
**VsanObjectUuids** | **List&lt;string&gt;** | A set of UUIDs of the underlying vSAN objects.  | [optional] 
**AccessPoints** | [**List&lt;KeyValue&gt;**](KeyValue.md) | A key-value pair indicating the access points for the file share.  The key of an access point is the type of the protocol, and the value of the access point is the connection string for accessing the file share with FQDNs. The supported type of protocol string is NFSv4/NFSv3/SMB.  | [optional] 
**ManagedBy** | **string** | The managing entity of the file share.  See also *VsanFileShareManagingEntity_enum*.  | [optional] 
**FileServerFQDN** | **string** | The FQDN of the file server serving this file share.  Note: This can be used to construct the command to manage SMB shares on MMC (Microsoft Management Console). e.g., run \&quot;fsmgmt.msc /computer:\\\\&amp;lt;fileServerFQDN&amp;gt;\&quot; on Windows client to manage SMB shares from MMC.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

