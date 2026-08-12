# Vcenter.ViJson.OpenApi.Model.VirtualMachineCloneSpecTpmProvisionPolicyEnum
TPM provisioning policies used when cloning a VM with a virtual TPM device.  Possible values: - `copy`: The virtual TPM is copied.      The virtual machine clone will have access   to the original virtual machine's TPM secrets. - `replace`: The virtual TPM is replaced with a new one.      The virtual machine clone   will not have access to the original virtual machine's TPM secrets.   If the virtual TPM operates in read-only mode (   VirtualTPM#readOnly}), the clone virtual machine will be configured   with a regularly operating (non read-only) virtual TPM.  ***Since:*** vSphere API Release 8.0.0.1 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

