# Vcenter.ViJson.OpenApi.Model.VirtualMachineForkConfigInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ParentEnabled** | **bool** | Flag to indicate whether this virtual machine is a parent enabled virtual machine.  If this vm is not a parent enabled vm this property will be unset. When set into the vim.vm.ConfigSpec this flag will be ignored.  | [optional] 
**ChildForkGroupId** | **string** | The fork group ID identifies the parent group of which this child VirtualMachine is a child.  Applicable for child VirtualMachines only.  | [optional] 
**ParentForkGroupId** | **string** | The fork group ID identifies the parent group which this VirtualMachine belongs to.  Applicable for parent VirtualMachines only.  | [optional] 
**ChildType** | **string** | The flag to indicate the fork child type.  For a persistent child virtual machine, once it is powered on, it will become a linked clone of its parent and this flag will be set to &#39;none&#39;.  See also *VirtualMachineForkConfigInfoChildType_enum*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

