# Vcenter.ViJson.OpenApi.Model.VslmCreateSpecDiskFileBackingSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Datastore** | [**ManagedObjectReference**](ManagedObjectReference.md) | The datastore managed object where this backing is located.  Refers instance of *Datastore*.  | 
**Path** | **string** | Relative location in the specified datastore where disk needs to be created.  If not specified disk gets created at the default VStorageObject location on the specified datastore.  | [optional] 
**ProvisioningType** | **string** | Provisioning type.  See also *BaseConfigInfoDiskFileBackingInfoProvisioningType_enum*  If unset, system will first look up the provisioning type specified in the policy. If still not found, the default *thin* will be used..  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

