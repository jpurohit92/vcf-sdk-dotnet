# Vcenter.ViJson.OpenApi.Model.VsanClusterDitEncryptionHealthSummary

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OverallHealth** | **string** | Data-in-transit encryption configuration consistency health across all hosts in the cluster.  See also *VsanHealthStatusType_enum*.  | 
**Enabled** | **bool** | Whether data-in-transit encryption is enabled in the cluster.  | [optional] 
**HostResults** | [**List&lt;VsanDitEncryptionHealthSummary&gt;**](VsanDitEncryptionHealthSummary.md) | Data-in-transit encryption health results on all of vSAN hosts in the cluster.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

