# Vcenter.ViJson.OpenApi.Model.HostNvmeOpaqueTransportParameters

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Trtype** | **string** | The transport type.  Corresponds to the TRTYPE field in the Discovery Log Page Entry as specified by the NVME over Fabrics spec. The set of possible values is described in *HostNvmeTransportType_enum*.  | 
**Traddr** | **string** | The transport address.  Corresponds to the TRADDR field in the Discovery Log Page Entry as specified by the NVME over Fabrics spec.  | 
**Adrfam** | **string** | Indicates the address family of the address specified above.  Corresponds to the ADRFAM field in the Discovery Log Page Entry as specified by the NVME over Fabrics spec. The set of supported values is described in *HostNvmeTransportParametersNvmeAddressFamily_enum*.  | 
**Trsvcid** | **string** | Transport service identifier.  Corresponds to the TRSVCID field in the Discovery Log Page Entry as specified by the NVME over Fabrics spec. Its interpretation varies depending on the transport type.  | 
**Tsas** | **byte[]** | Transport specific address subtype.  Corresponds to the TSAS field in the Discovery Log Page Entry as specified by the NVME over Fabrics spec. Its interpretation varies depending on the transport type.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

