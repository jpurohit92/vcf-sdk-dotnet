# Vcenter.ViJson.OpenApi.Model.VirtualMachineSgxTargetInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The identification of the endpoint on the host.  The format of this depends on the kind of virtual device this endpoints is used for. For example, for a VirtualEthernetCard this would be a networkname, and for a VirtualCDROM it would be a device name.  | 
**ConfigurationTag** | **List&lt;string&gt;** | List of configurations that this device is available for.  This is only filled out if more than one configuration is requested.  | [optional] 
**MaxEpcSize** | **long** | Maximum size, in bytes, of EPC available on the compute resource.  | 
**FlcModes** | **List&lt;string&gt;** | FLC modes available in the compute resource.  The set of possible values are described in *VirtualMachineSgxInfoFlcModes_enum*.  | [optional] 
**LePubKeyHashes** | **List&lt;string&gt;** | Public key hashes of the provider launch enclaves available in the compute resource.  | [optional] 
**RequireAttestationSupported** | **bool** | Whether the host/cluster supports requiring SGX remote attestation.  ***Since:*** vSphere API Release 8.0.0.1  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

