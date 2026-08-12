# Vcenter.ViJson.OpenApi.Model.VsanEncryptionTransitionStateEnum
The state of host during data-in-transit encryption configuration change for a vSAN cluster.  The final configuration whether to turn on or turn off encryption for the cluster is defined in *VsanHostConfigInfoEx.dataInTransitEncryptionInfo*.  Possible values: - `settled`: Stable state.      Host enforces all sessions to be encrypted or non-encrypted according to the encryption configuration. - `preparing`: Host accepts both encrypted and non-encrypted messages.      For enable process, host transfers non-encrypted messages; for disable process, host transfers encrypted messages. - `prepared`: Host accepts both encrypted and non-encrypted messages.      For enable process, host transfers encrypted messages; for disable process, host transfers non-encrypted messages. - `EncryptionTransitionState_Unknown`: Represent the value when the lower version client cannot recognize the enum value. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

