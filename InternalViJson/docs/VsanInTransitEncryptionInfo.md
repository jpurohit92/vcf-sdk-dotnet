# Vcenter.ViJson.OpenApi.Model.VsanInTransitEncryptionInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **bool** | Whether data-in-transit encryption is enabled in the cluster.  | [optional] 
**RekeyInterval** | **int** | Periodical rekeying interval in minutes.  Default interval is 1440, i.e. 24 hours. Minimal interval is 30 minutes and maximum is 10080, i.e. 7 days.  | [optional] 
**TransitionState** | **string** | Transition state is used to mark intermediate stages during encryption configuration change for a vSAN cluster.  Default to &#39;settled&#39;.  See also *VsanEncryptionTransitionState_enum*.  | [optional] 
**ServerClusterUuid** | **string** | The server cluster UUID where the remote vSAN datastores are hosted.  This is used to support data in transit encryption for remote vSAN.  | [optional] 
**ClientClusterUuid** | **string** | The client cluster UUID which mounts the remote vSAN datastore.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

