# Vcenter.ViJson.OpenApi.Model.VirtualMachineSgxInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EpcSize** | **long** | Size of vEPC, in megabytes.  | 
**FlcMode** | **string** | FLC mode for the virtual machine.  The set of possible values are described in *VirtualMachineSgxInfoFlcModes_enum*. If no value is specified, then \&quot;unlocked\&quot; will be used.  | [optional] 
**LePubKeyHash** | **string** | Public key hash of the provider launch enclave.  This is the SHA256 digest of the SIGSTRUCT.MODULUS(MR\\_SIGNER) of the provider launch enclave. This hash must only be provided when the launch enclave mode is \&quot;locked\&quot;, for the other cases the hash is ignored.  | [optional] 
**RequireAttestation** | **bool** | Indicates whether or not a virtual machine requires remote attestation.  ***Since:*** vSphere API Release 8.0.0.1  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

