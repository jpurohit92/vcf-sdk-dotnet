# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementVirtualMachineClassesVirtualDevices
This schema is deprecated as of __vSphere API 8.0.2.0__.  Use device changes in VirtualMachineConfigSpec associated with the VM class to add vGPU and Dynamic DirectPath I/O virtual devices.   The Vcenter.NamespaceManagement.VirtualMachineClasses.VirtualDevices schema contains information about the virtual devices associated with a VM class.  This schema was added in __vSphere API 7.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VgpuDevices** | [**List&lt;VcenterNamespaceManagementVirtualMachineClassesVGPUDevice&gt;**](VcenterNamespaceManagementVirtualMachineClassesVGPUDevice.md) | This property is deprecated as of __vSphere API 8.0.2.0__.  List of vGPU devices.  This property was added in __vSphere API 7.0.3.0__.  If missing or &#x60;null&#x60;, no vGPU devices are present. | [optional] 
**DynamicDirectPathIoDevices** | [**List&lt;VcenterNamespaceManagementVirtualMachineClassesDynamicDirectPathIODevice&gt;**](VcenterNamespaceManagementVirtualMachineClassesDynamicDirectPathIODevice.md) | This property is deprecated as of __vSphere API 8.0.2.0__.  List of Dynamic DirectPath I/O devices.  This property was added in __vSphere API 7.0.3.0__.  If missing or &#x60;null&#x60;, no Dynamic DirectPath I/O devices are present. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

