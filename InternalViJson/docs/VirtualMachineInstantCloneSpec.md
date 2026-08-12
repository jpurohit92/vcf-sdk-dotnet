# Vcenter.ViJson.OpenApi.Model.VirtualMachineInstantCloneSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the cloned virtual machine.  | 
**Location** | [**VirtualMachineRelocateSpec**](VirtualMachineRelocateSpec.md) | A type of *VirtualMachineRelocateSpec* that specifies the location of resources the newly created virtual machine will use.  The location might be empty or specify: - The folder where the virtual machine should be located. If not   specified, the root VM folder of the source VM will be used. - A datastore where the InstantCloned virtual machine will be located   on the physical storage. - A resource pool determines where compute resources will be   available to the clone. - A device change specification. The only allowed device changes   are edits of VirtualEthernetCard and filebacked Serial/Parallel   ports.    All other settings are NOT supported.  | 
**Config** | [**List&lt;OptionValue&gt;**](OptionValue.md) | A list of key value pairs that will be passed to the destination VM.  These pairs should be used to provide user-defined customization to differentiate the destination VM from the source VM. Values will be queryable via destination VM&#39;s *VirtualMachineConfigInfo.extraConfig*.  | [optional] 
**BiosUuid** | **string** | 128-bit SMBIOS UUID of a virtual machine represented as a hexadecimal string in \&quot;12345678-abcd-1234-cdef-123456789abc\&quot; format.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

