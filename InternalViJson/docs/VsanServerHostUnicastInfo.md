# Vcenter.ViJson.OpenApi.Model.VsanServerHostUnicastInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HostUuid** | **string** | Server host UUID.  | 
**NodeType** | **string** | Server node type to differentiate data nodes from witness and metadata nodes.  See also *ServerNodeType_enum*.  | [optional] 
**UnicastSpec** | [**List&lt;VsanUnicastAddressInfo&gt;**](VsanUnicastAddressInfo.md) | The list of unicast information for the host in a server cluster.  | [optional] 
**ThumbprintList** | [**List&lt;VirtualMachineCertThumbprint&gt;**](VirtualMachineCertThumbprint.md) | A list of SSL certificate thumbprints with supported secure hashing algorithms.  See *VirtualMachineCertThumbprint*  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

