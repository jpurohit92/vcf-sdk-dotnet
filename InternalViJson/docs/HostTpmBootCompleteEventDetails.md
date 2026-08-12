# Vcenter.ViJson.OpenApi.Model.HostTpmBootCompleteEventDetails
Details of a Trusted Platform Module (TPM) event recording the measurement of boot complete event.  The event digest is hash of the string \"Boot Complete\" including the nul character.  ***Since:*** vSphere API Release 8.0.1.0 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DataHash** | **List&lt;int&gt;** | Value of the Platform Configuration Register (PCR) for this event.  | 
**DataHashMethod** | **string** | Method in which the digest hash is calculated.  The set of possible values is described in *HostDigestInfoDigestMethodType_enum*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

