# Vcenter.ViJson.OpenApi.Model.VsanEncryptedClusterRekeyRequestType
The parameters of *VsanVcClusterConfigSystem.VsanEncryptedClusterRekey_Task*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EncryptedCluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target VC cluster  Refers instance of *ClusterComputeResource*.  | 
**DeepRekey** | **bool** | True to perform a deep rekey. Its default value is false when not provided, which means shallow rekey is performed  | [optional] 
**AllowReducedRedundancy** | **bool** | This optional parameter is only applicable for deep rekey when it needs to migrate data across cluster for changing vSAN disk format. The default value is &#39;false&#39; if not specified See *VimVsanReconfigSpec.allowReducedRedundancy*, *ensureObjectAccessibility*, and *evacuateAllData*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

