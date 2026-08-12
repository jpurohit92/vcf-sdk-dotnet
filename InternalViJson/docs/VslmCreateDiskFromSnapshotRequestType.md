# Vcenter.ViJson.OpenApi.Model.VslmCreateDiskFromSnapshotRequestType
The parameters of *VslmVStorageObjectManager.VslmCreateDiskFromSnapshot_Task*.  This structure may be used only with operations rendered under `/vslm`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ID**](ID.md) | The ID of the virtual storage object.  | 
**SnapshotId** | [**ID**](ID.md) | The ID of the snapshot of the virtual storage object.  | 
**Name** | **string** | A user friendly name to be associated with the new disk.  | 
**Profile** | [**List&lt;VirtualMachineProfileSpec&gt;**](VirtualMachineProfileSpec.md) | SPBM Profile requirement on the new virtual storage object. If not specified datastore default policy would be assigned.  | [optional] 
**Crypto** | [**CryptoSpec**](CryptoSpec.md) | Crypto information of the new disk.  | [optional] 
**Path** | **string** | Relative location in the specified datastore where disk needs to be created. If not specified disk gets created at the default VStorageObject location on the specified datastore.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

