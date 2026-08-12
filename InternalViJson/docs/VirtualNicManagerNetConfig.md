# Vcenter.ViJson.OpenApi.Model.VirtualNicManagerNetConfig

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NicType** | **string** | The NicType of this NetConfig.  | 
**MultiSelectAllowed** | **bool** | Whether multiple nics can be selected for this nicType.  | 
**CandidateVnic** | [**List&lt;HostVirtualNic&gt;**](HostVirtualNic.md) | List of VirtualNic objects that may be used.  This will be a subset of the list of VirtualNics in *HostNetworkInfo.vnic*.  | [optional] 
**SelectedVnic** | **List&lt;string&gt;** | List of VirtualNic objects that are selected for use.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

