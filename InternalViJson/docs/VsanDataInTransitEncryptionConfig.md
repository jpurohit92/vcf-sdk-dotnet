# Vcenter.ViJson.OpenApi.Model.VsanDataInTransitEncryptionConfig

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **bool** | Whether data-in-transit encryption is enabled in the cluster.  | [optional] 
**RekeyInterval** | **int** | Periodical rekeying interval in minutes.  Default interval is 1440, i.e. 24 hours. Minimal interval is 30 minutes and maximum is 10080, i.e. 7 days.  | [optional] 
**State** | **string** | Transition state is read-only property which is used to mark intermediate stages during data-in-transit configuration change for a vSAN cluster.  Refer to *VsanEncryptionTransitionState_enum*  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

