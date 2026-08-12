# Vcenter.ViJson.OpenApi.Model.VsanHostClusterStatus

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uuid** | **string** | VSAN service cluster UUID.  | [optional] 
**NodeUuid** | **string** | VSAN node UUID for this host.  | [optional] 
**Health** | **string** | VSAN health state for this host.  See also *VsanHostHealthState_enum*.  | 
**NodeState** | [**VsanHostClusterStatusState**](VsanHostClusterStatusState.md) | VSAN node state for this host.  | 
**MemberUuid** | **List&lt;string&gt;** | List of UUIDs for VSAN nodes known to this host.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

