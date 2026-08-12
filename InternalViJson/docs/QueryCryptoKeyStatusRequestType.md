# Vcenter.ViJson.OpenApi.Model.QueryCryptoKeyStatusRequestType
The parameters of *CryptoManagerKmip.QueryCryptoKeyStatus*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**KeyIds** | [**List&lt;CryptoKeyId&gt;**](CryptoKeyId.md) | \\[in\\] The Crypto Key Ids to query.  | [optional] 
**CheckKeyBitMap** | **int** | \\[in\\] The key state to check. Supported value: 0x01. check if key data is available to VC. 0x02. check the VMs which use that key. 0x04. check the hosts using this key as host key. 0x08. Check 3rd party program which use that key. Other bits - reserved and will be ignored.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

