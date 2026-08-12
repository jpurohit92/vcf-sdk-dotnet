# Vcenter.ViJson.OpenApi.Model.VsanXvcClientInfoSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientVc** | **string** | Client VC name which owns this client cluster  | 
**VcUuid** | **string** | The uuid of the client vCenter  | [optional] 
**VcVersion** | **string** | The API version of the client vCenter  | [optional] 
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The client cluster which requests to mount specified the vSAN datastores.  Refers instance of *ClusterComputeResource*.  | [optional] 
**ClusterName** | **string** | The client cluster name which requests to mount specified the vSAN datastores.  | [optional] 
**ClusterUuid** | **string** | The uuid of the client cluster  | [optional] 
**VsanFormatVersion** | **string** | The client cluster vSAN format version.  This is passed to server side for vSAN version compatibility check.  | [optional] 
**MinVsanFormatVersion** | **string** | Minimum required cluster vSAN format version.  This is passed to server side for vSAN version compatibility check.  | [optional] 
**Datastore** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | The server datastores requested to mount across VC  Refers instances of *Datastore*.  | [optional] 
**UnicastInfo** | [**VsanHostClientClusterUnicastInfo**](VsanHostClientClusterUnicastInfo.md) | The client cluster&#39;s unicast info.  It is used for supporting XVC DIT. The remote unicast agent needs to be set because when user mounts remote vSAN datastore, server cluster needs to do authentication on client host when remote DIT is enabled.  | [optional] 
**SaGeneration** | **long** | The generation ID for service account lifecycle management.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

