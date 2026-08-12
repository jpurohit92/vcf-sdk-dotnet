# Vcenter.ViJson.OpenApi.Model.CannotMoveVsanEnabledHost
Fault thrown for the case that an attempt is made to move a host which is enabled for VSAN into an unsuitable *ClusterComputeResource*.  The destination vim.ClusterComputeResource may be disabled for VSAN, or may be using VSAN with a different cluster UUID.  See also *ClusterComputeResource.AddHost_Task*, *ClusterComputeResource.MoveHostInto_Task*, *ClusterComputeResource.MoveInto_Task*, *VsanClusterUuidMismatch*, *DestinationVsanDisabled*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

