# Vcenter.ViJson.OpenApi.Model.VsanClusterEncryptionHealthSummary

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OverallHealth** | **string** | Overall health state for encryption configuration and Key Management Server connection on vCenter and across all hosts in the cluster.  | [optional] 
**ConfigHealth** | **string** | Encryption configuration consistency health across all hosts in the cluster.  | [optional] 
**KmsHealth** | **string** | Key Management Server connection health on vCenter and across all hosts in the cluster.  | [optional] 
**VcKmsResult** | [**VsanVcKmipServersHealth**](VsanVcKmipServersHealth.md) | Key Management Servers connection health result on vCenter side.  | [optional] 
**HostResults** | [**List&lt;VsanEncryptionHealthSummary&gt;**](VsanEncryptionHealthSummary.md) | Encryption health results on all of vSAN hosts in the cluster.  | [optional] 
**AesniHealth** | **string** | AES-NI configuration consistency health across all hosts in the cluster.  Valid value can be \\[&#39;green&#39; , &#39;yellow&#39;, &#39;red&#39;, &#39;unknown&#39;\\]  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

