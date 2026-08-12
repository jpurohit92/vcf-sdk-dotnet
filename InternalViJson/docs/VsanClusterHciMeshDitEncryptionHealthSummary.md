# Vcenter.ViJson.OpenApi.Model.VsanClusterHciMeshDitEncryptionHealthSummary

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OverallHealth** | **string** | The overall HCI Mesh data-in-transit encryption health state.  See also *VsanHealthStatusType_enum*.  | 
**HostClientClusterSummary** | [**List&lt;VsanHostHciMeshDitEncryptionHealthSummary&gt;**](VsanHostHciMeshDitEncryptionHealthSummary.md) | The list of this cluster&#39;s all hosts&#39; HCI Mesh data-in-transit encryption health summary for all the peer client clusters that mount this cluster.  | [optional] 
**HostServerClusterSummary** | [**List&lt;VsanHostHciMeshDitEncryptionHealthSummary&gt;**](VsanHostHciMeshDitEncryptionHealthSummary.md) | The list of this cluster&#39;s all hosts&#39; HCI Mesh data-in-transit encryption health summary for all the peer server clusters that this cluster mount.  | [optional] 
**ServerClusterSummary** | [**List&lt;VsanClientServerHciMeshDitEncryptionHealthSummary&gt;**](VsanClientServerHciMeshDitEncryptionHealthSummary.md) | The list of HCI Mesh data-in-transit encryption health summary between this cluster and all the peer server clusters that this cluster mounts.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

