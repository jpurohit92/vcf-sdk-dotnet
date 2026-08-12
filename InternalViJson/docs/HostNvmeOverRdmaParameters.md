# Vcenter.ViJson.OpenApi.Model.HostNvmeOverRdmaParameters

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Address** | **string** | The address of the connection target.  | 
**AddressFamily** | **string** | Indicates the type of the address specified above.  If unset, it is assumed to be an IPv4 address. The set of possible values is described in *HostNvmeTransportParametersNvmeAddressFamily_enum*. Note that not all of the address families may be supported for establishing a connection over RDMA.  | [optional] 
**PortNumber** | **int** | The port number of the RDMA target port.  When IPv4/IPv6 is used as address family above, the port number needs to be specified. If this field is unset, a default value of 4420 is assumed as per the IANA assignment: https://www.iana.org/assignments/service-names-port-numbers/service-names-port-numbers.xhtml  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

