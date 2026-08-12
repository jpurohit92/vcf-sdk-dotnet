# Vcenter.ViJson.OpenApi.Model.HostSgxInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SgxState** | **string** | SGX state of the host.  The set of supported values are described in *HostSgxInfoSgxStates_enum*.  | 
**TotalEpcMemory** | **long** | Size of physical EPC in bytes.  | 
**FlcMode** | **string** | FLC mode of the host.  The set of supported values are described in *HostSgxInfoFlcModes_enum*.  | 
**LePubKeyHash** | **string** | Public key hash of the provider launch enclave.  This is the SHA256 digest of the SIGSTRUCT.MODULUS(MR\\_SIGNER) of the provider launch enclave. This attribute is set only if attribute flcMode is locked.  | [optional] 
**RegistrationInfo** | [**HostSgxRegistrationInfo**](HostSgxRegistrationInfo.md) | ***Since:*** vSphere API Release 8.0.0.1  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

