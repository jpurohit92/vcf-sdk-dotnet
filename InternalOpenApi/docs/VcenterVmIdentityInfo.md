# Vcenter.Automation.OpenApi.Model.VcenterVmIdentityInfo
The Vcenter.Vm.Identity.Info schema contains information about the identity of a virtual machine.  This schema was added in __vSphere API 6.7.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Virtual machine name.  This property was added in __vSphere API 6.7.1__. | 
**BiosUuid** | **string** | 128-bit SMBIOS UUID of a virtual machine represented as a hexadecimal string in \&quot;12345678-abcd-1234-cdef-123456789abc\&quot; format.  This property was added in __vSphere API 6.7.1__. | 
**InstanceUuid** | **string** | VirtualCenter-specific 128-bit UUID of a virtual machine, represented as a hexadecimal string. This identifier is used by VirtualCenter to uniquely identify all virtual machine instances, including those that may share the same SMBIOS UUID.  This property was added in __vSphere API 6.7.1__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

