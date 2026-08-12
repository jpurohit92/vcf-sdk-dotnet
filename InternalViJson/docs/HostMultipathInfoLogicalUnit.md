# Vcenter.ViJson.OpenApi.Model.HostMultipathInfoLogicalUnit

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | Linkable identifier.  | 
**Id** | **string** | Identifier of LogicalUnit.  Use this id to configure LogicalUnit multipathing policy using *HostStorageSystem.SetMultipathLunPolicy*.  | 
**Lun** | **string** | SCSI device corresponding to logical unit.  | 
**Path** | [**List&lt;HostMultipathInfoPath&gt;**](HostMultipathInfoPath.md) | Array of paths available to access this LogicalUnit.  | 
**Policy** | [**HostMultipathInfoLogicalUnitPolicy**](HostMultipathInfoLogicalUnitPolicy.md) | Policy that the logical unit should use when selecting a path.  | 
**StorageArrayTypePolicy** | [**HostMultipathInfoLogicalUnitStorageArrayTypePolicy**](HostMultipathInfoLogicalUnitStorageArrayTypePolicy.md) | Policy used to determine how a storage device is accessed.  This policy is currently immutable.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

