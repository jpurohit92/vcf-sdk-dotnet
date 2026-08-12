# Vcenter.ViJson.OpenApi.Model.VsanQueryObjectIdentitiesRequestType
The parameters of *VsanObjectSystem.VsanQueryObjectIdentities*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | vSAN cluster. Ignored if called against host.  ***Required privileges:*** System.Read  Refers instance of *ComputeResource*.  | [optional] 
**ObjUuids** | **List&lt;string&gt;** | The vSAN object UUIDs for querying. Unset to query all of vSAN objects  | [optional] 
**ObjTypes** | **List&lt;string&gt;** | Querying the vSAN objects with given types, only the object whose type in this list will be returned. All of available object types include &#39;vmswap&#39;, &#39;vdisk&#39;, &#39;namespace&#39;, &#39;vmem&#39;, &#39;stats&#39;, &#39;other&#39;, &#39;iscsiHome&#39;, &#39;iscsiLun&#39;, &#39;iscsiTarget&#39; and &#39;fileShare&#39;. Unset to query all of vSAN objects with any type  | [optional] 
**IncludeHealth** | **bool** | If the result includes the object health status. Default is False  | [optional] 
**IncludeObjIdentity** | **bool** | If the result includes all of the object identity. Default is True if it&#39;s unset  | [optional] 
**IncludeSpaceSummary** | **bool** | If the result includes the vSAN space consumption summarizing by object type. Currently, it&#39;s not supported to include both of space summary and object identity in the result. Default is false.  | [optional] 
**ExtraQuerySpec** | [**VsanObjIdentityQuerySpec**](VsanObjIdentityQuerySpec.md) | This parameter only takes effect for host level API. The vSAN object identity query spec to specify detailed query specification like remote vSAN or VMFS datastores. If no extraQquerySpec is specified, the original logic to return all identities of local vSAN datastores will be applied. Note for any nonlocal vsan datastores provided, all the specified filter like objUuids, objTypes, include\\* won&#39;t take affect.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

