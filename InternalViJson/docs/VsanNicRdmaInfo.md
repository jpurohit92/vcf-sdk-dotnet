# Vcenter.ViJson.OpenApi.Model.VsanNicRdmaInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RdmaCapable** | **bool** | Whether physical NIC is RDMA capable.  | [optional] 
**RdmaProtocolCapable** | **string** | Type of network protocol supported by RDMA.  See also *RdmaProtocol_enum*.  | [optional] 
**DcbEnabled** | **bool** | True indicates the Data Center Bridging (DCB) mode is enabled on this physical NIC.  | [optional] 
**DcbMode** | **string** | The DCB mode for the physial NIC including &#39;CEE&#39;, &#39;IEEE&#39; and &#39;PRE-CEE&#39;.  IEEE mode is recommended to ensure lossless transport in layer 2 environment.  | [optional] 
**PfcEnabled** | **bool** | True indicates the Priority-based Flow Control (PFC) is enabled on the physical NIC.  | [optional] 
**PfcConfig** | **string** | The Priority-based Flow Control (PFC) configuration on physical NIC.  To ensure lossless layer 2 environment, it&#39;s must required to control the traffic flow, which can be achieved by configuring the priority value to 3 or 4.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

