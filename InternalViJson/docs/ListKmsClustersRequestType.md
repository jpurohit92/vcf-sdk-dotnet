# Vcenter.ViJson.OpenApi.Model.ListKmsClustersRequestType
The parameters of *CryptoManagerKmip.ListKmsClusters*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IncludeKmsServers** | **bool** | \\[in\\] Whether to list KMS servers information in the cluster. By default will not include the KMS servers information.  | [optional] 
**ManagementTypeFilter** | **int** | \\[in\\] The KMS cluster management type filter. Bit map values: 0x01 - Return VC managed Key Providers registered in the CryptoManager. 0x02 - Return Trusted Key Providers registered in the CryptoManager. 0x04 - Return Trusted Key Providers which are not registered with the CryptoManager. 0x08 - Return Native Key Providers. others - reserved, will be ignored If omitted or -1, then all kinds of Key Providers will be returned.  | [optional] 
**StatusFilter** | **int** | \\[in\\] The Key Provider status filter. Bit map values: 0x01 - Return active Key Providers. 0x02 - Return inactive Key Providers. others - reserved, will be ignored If omitted or -1, then all status of Key Providers will be returned.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

