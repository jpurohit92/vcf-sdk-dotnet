# Vcenter.ViJson.OpenApi.Model.HostProtocolEndpoint

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PeType** | **string** | Deprecated from all vmodl version above @released(\&quot;6.0\&quot;) Use type instead.  Type of ProtocolEndpoint See *HostProtocolEndpointPEType_enum*  | 
**Type** | **string** | Type of ProtocolEndpoint See *HostProtocolEndpointProtocolEndpointType_enum*  | [optional] 
**Uuid** | **string** | Identifier for PE assigned by VASA Provider  | 
**HostKey** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | Set of ESX hosts which can see the same PE  Refers instances of *HostSystem*.  | [optional] 
**StorageArray** | **string** | Associated Storage Array  | [optional] 
**NfsServer** | **string** | NFSv3 and NFSv4x PE will contain information about NFS Server For NFSv4x this field may contain comma separated list of IP addresses which are associated with the NFS Server  | [optional] 
**NfsDir** | **string** | NFSv3 and NFSv4x PE will contain information about NFS directory  | [optional] 
**NfsServerScope** | **string** | NFSv4x PE will contain information about NFSv4x Server Scope  | [optional] 
**NfsServerMajor** | **string** | NFSv4x PE will contain information about NFSv4x Server Major  | [optional] 
**NfsServerAuthType** | **string** | NFSv4x PE will contain information about NFSv4x Server Auth-type  | [optional] 
**NfsServerUser** | **string** | NFSv4x PE will contain information about NFSv4x Server User  | [optional] 
**DeviceId** | **string** | SCSI PE will contain information about SCSI device ID  | [optional] 
**UsedByStretchedContainer** | **bool** | Indicates whether the PE is being used to access a stretch-capable container  ***Since:*** vSphere API Release 8.0.3.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

