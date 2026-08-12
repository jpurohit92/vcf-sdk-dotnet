# Vcenter.ViJson.OpenApi.Model.VsanHostHciMeshDitEncryptionHealthSummary

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Hostname** | **string** | The host name.  | 
**ClusterUuid** | **string** | The UUID of the cluster where the host is in.  | 
**ClusterName** | **string** | The name of the cluster where the host is in.  | 
**OwnerVc** | **string** | The vCenter that owns the cluster where the host is in.  | 
**IsLocalOwnerVc** | **bool** | If the vCenter that owns the host cluster is local.  | [optional] 
**Capable** | **bool** | If the host is capable of HCI Mesh data-in-transit encryption.  | [optional] 
**ClusterHealths** | [**List&lt;VsanHostHciMeshDitEncryptionHealth&gt;**](VsanHostHciMeshDitEncryptionHealth.md) | The health summary of all the peer client or server clusters.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

