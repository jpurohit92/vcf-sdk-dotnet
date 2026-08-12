# Vcenter.ViJson.OpenApi.Model.VirtualVmxnet3Vrdma

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uptv2Enabled** | **bool** | Indicates whether UPTv2(Uniform Pass-through version 2) compatibility is enabled on this network adapter.  UPTv2 is only available on Vmxnet3 adapter. Clients can set this property enabled or disabled if ethernet virtual device is Vmxnet3. It requires the VM hardware version is compatible with ESXi version which has enabled smartnic feature.  ***Since:*** vSphere API Release 8.0.0.1  | [optional] 
**StrictLatencyConfig** | [**VirtualVmxnet3StrictLatencyConfig**](VirtualVmxnet3StrictLatencyConfig.md) | Indicates whether strict latency parameters are configured on this network adapter.  Clients can set these parameters to control behaviors on this network adapter, e.g., set the TX/RX ring size, etc. Requires VM hardware version compatible with ESXi release supporting the \&quot;real-time switch\&quot; feature.  ***Since:*** vSphere API Release 8.0.3.1  | [optional] 
**DeviceProtocol** | **string** | VRDMA Device protocol.  See *VirtualVmxnet3VrdmaOptionDeviceProtocols_enum* for more information.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

