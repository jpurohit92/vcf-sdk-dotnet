# Vcenter.ViJson.OpenApi.Model.HostNvmeOverTcpParameters

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Address** | **string** | The address of the connection target.  It is expected to be an IPv4 or IPv6 address.  | 
**PortNumber** | **int** | The port number of the TCP target port.  If this field is unset, the default value of 8009 is assumed as per the IANA assignment: https://www.iana.org/assignments/service-names-port-numbers/service-names-port-numbers.xhtml  | [optional] 
**DigestVerification** | **string** | Digest verification parameter.  When used in a discovery or connect spec, this parameter specifies the requested digest verification setting. The list of supported values is described in *HostDigestVerificationSetting_enum*. If unset, a default value of disabled is assumed. For details, see: - NVM Express Technical Proposal 8000 - NVMe/TCP Transport,   Section 7.4.10.2, \&quot;Initialize Connection Request PDU (ICReq)\&quot; - DGST field.    When part of *HostNvmeDiscoveryLogEntry*, this value is unset.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

