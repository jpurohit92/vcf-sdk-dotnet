# Vcenter.ViJson.OpenApi.Model.ComputeResourceConfigInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VmSwapPlacement** | **string** | Swapfile placement policy for virtual machines within this compute resource.  Any policy except for \&quot;inherit\&quot; is a valid value for this property; the default is \&quot;vmDirectory\&quot;. This setting will be honored for each virtual machine within the compute resource for which the following is true: - The virtual machine is executing on a host that has the   *perVmSwapFiles* capability. - The virtual machine configuration&#39;s   *swapPlacement* property is set   to \&quot;inherit\&quot;.    See also *VirtualMachineConfigInfoSwapPlacementType_enum*.  | 
**SpbmEnabled** | **bool** | Flag indicating whether or not the SPBM(Storage Policy Based Management) feature is enabled on this compute resource  | [optional] 
**DefaultHardwareVersionKey** | **string** | Key for Default Hardware Version used on this compute resource in the format of *VirtualMachineConfigOptionDescriptor.key*.  This field affects *VirtualMachineConfigOptionDescriptor.defaultConfigOption* returned by *ComputeResource.environmentBrowser* of this object and all its children with this field unset.  | [optional] 
**MaximumHardwareVersionKey** | **string** | Key for Maximum Hardware Version used on this compute resource in the format of *VirtualMachineConfigOptionDescriptor.key*.  This field affects *VirtualMachineConfigOptionDescriptor.defaultConfigOption* returned by *ComputeResource.environmentBrowser* of this object and all its children with this field unset.  ***Since:*** vSphere API Release 7.0.2.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

