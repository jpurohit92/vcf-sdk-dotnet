# Vcenter.ViJson.OpenApi.Model.VirtualMachineVirtualPMem

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SnapshotMode** | **string** | An enum describing behavior of NVDIMM devices when a VM snapshot is taken and restored.  If unset, taking a VM snapshot will fail when the VM is configured with NVDIMMs. See *VirtualMachineVirtualPMemSnapshotMode_enum* for supported values. The snapshot mode applies to all NVDIMMs configured for the VM. Property is currently only applicable to VMs with virtual NVDIMMs and not applicable to vPMem disks. Setting this property will fail if the VM has existing snapshots.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

