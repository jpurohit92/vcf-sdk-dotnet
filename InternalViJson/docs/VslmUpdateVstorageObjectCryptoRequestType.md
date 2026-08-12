# Vcenter.ViJson.OpenApi.Model.VslmUpdateVstorageObjectCryptoRequestType
The parameters of *VslmVStorageObjectManager.VslmUpdateVstorageObjectCrypto_Task*.  This structure may be used only with operations rendered under `/vslm`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ID**](ID.md) | The ID of the virtual storage object.  | 
**Profile** | [**List&lt;VirtualMachineProfileSpec&gt;**](VirtualMachineProfileSpec.md) | New profile requirement on the virtual storage object.  | [optional] 
**DisksCrypto** | [**DiskCryptoSpec**](DiskCryptoSpec.md) | The crypto information of each disk on the chain.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

