# Vcenter.Automation.OpenApi.Model.VcenterOvfExtraConfig
The Vcenter.Ovf.ExtraConfig schema contains the information about a vmw:ExtraConfig element which can be used to specify configuration settings that are transferred directly to the ```.vmx``` file. The behavior of the vmw:ExtraConfig element is similar to the ```extraConfig``` property of the ```VirtualMachineConfigSpec``` object in the VMware vSphere API. Thus, the same restrictions apply, such as you cannot set values that could otherwise be set with other properties in the ```VirtualMachineConfigSpec``` object. See the VMware vSphere API reference for details on this.    vmw:ExtraConfig elements may occur as direct child elements of a VirtualHardwareSection, or as child elements of individual virtual hardware items.    See *POST /vcenter/ovf/library-item/{ovfLibraryItemId}?action=deploy* and *POST /vcenter/ovf/library-item/{ovfLibraryItemId}?action=filter*.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | The key of the ExtraConfig element.  This property must be provided in the input parameters when deploying an OVF package. This property will always be present in the result when retrieving information about an OVF package. | [optional] 
**Value** | **string** | The value of the ExtraConfig element.  This property must be provided in the input parameters when deploying an OVF package. This property will always be present in the result when retrieving information about an OVF package. | [optional] 
**VirtualSystemId** | **string** | The identifier of the virtual system containing the vmw:ExtraConfig element.  This property is not used in the input parameters when deploying an OVF package. This property will always be present in the result when retrieving information about an OVF package. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

