# Vcenter.ViJson.OpenApi.Model.VirtualMachineVcpuConfig

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LatencySensitivity** | [**LatencySensitivity**](LatencySensitivity.md) | Latency sensitivity specification for this vcpu.  The latency sensitivity can be configured per-vcpu only when the VM *latencySensitivity* is configured to *high* in the same ConfigSpec. Setting *latencySensitivity*, but not setting the vcpu&#39;s LatencySensitivity would apply the VM&#39;s latency sensitivity level to all the vcpus of the VM. The latency sensitivity of the vcpu should not exceed the latency sensitivity level of the VM. The only allowed levels for vcpu Latency sensitivity are *high* or *normal*  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

