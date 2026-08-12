# Vcenter.ViJson.OpenApi.Model.GetDefaultKmsClusterRequestType
The parameters of *CryptoManagerKmip.GetDefaultKmsCluster*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Entity** | [**ManagedObjectReference**](ManagedObjectReference.md) | \\[in\\] The entity where the default KMS cluster to get. If omitted, then return global default KMS cluster.  Refers instance of *ManagedEntity*.  | [optional] 
**DefaultsToParent** | **bool** | \\[in\\] (Optional, default &#x3D; false) If set to true, then get the default kms cluster follow the entity hierarchy. That means if the entity has no default kms cluster, then try to get from its parent.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

