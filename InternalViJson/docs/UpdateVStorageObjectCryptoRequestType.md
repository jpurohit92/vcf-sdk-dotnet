# Vcenter.ViJson.OpenApi.Model.UpdateVStorageObjectCryptoRequestType
The parameters of *VcenterVStorageObjectManager.UpdateVStorageObjectCrypto_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ID**](ID.md) | The ID of the virtual storage object.  | 
**Datastore** | [**ManagedObjectReference**](ManagedObjectReference.md) | The datastore where the virtual storage object is located.  Refers instance of *Datastore*.  | 
**Profile** | [**List&lt;VirtualMachineProfileSpec&gt;**](VirtualMachineProfileSpec.md) | New profile requirement on the virtual storage object.  | [optional] 
**DisksCrypto** | [**DiskCryptoSpec**](DiskCryptoSpec.md) | The crypto information of each disk on the chain.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

