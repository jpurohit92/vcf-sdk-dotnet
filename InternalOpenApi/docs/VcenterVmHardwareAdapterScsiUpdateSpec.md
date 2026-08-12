# Vcenter.Automation.OpenApi.Model.VcenterVmHardwareAdapterScsiUpdateSpec
The Vcenter.Vm.Hardware.Adapter.Scsi.UpdateSpec schema describes the updates to be made to the configuration of a virtual SCSI adapter.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Sharing** | **string** | Bus sharing mode.    This property may only be modified if the virtual machine is not powered on.  Possible values:   - &#x60;NONE&#x60;: The virtual SCSI bus is not shared.   - &#x60;VIRTUAL&#x60;: The virtual SCSI bus is shared between two or more virtual machines. In this case, no physical machine is involved.   - &#x60;PHYSICAL&#x60;: The virtual SCSI bus is shared between two or more virtual machines residing on different physical hosts.   For more information see: *Vcenter.Vm.Hardware.Adapter.Scsi.Sharing*.  If missing or &#x60;null&#x60;, the value is unchanged. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

