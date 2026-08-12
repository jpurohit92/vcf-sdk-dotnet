# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementVirtualMachineClassesUpdateSpec
The Vcenter.NamespaceManagement.VirtualMachineClasses.UpdateSpec schema contains the specification required to update a VM class object.  This schema was added in __vSphere API 7.0.2.00100__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CpuCount** | **long** | The number of CPUs configured for virtual machine of this class.  This property was added in __vSphere API 7.0.2.00100__.  If missing or &#x60;null&#x60; the current value the will not be modified. | [optional] 
**CpuReservation** | **long** | This property is deprecated as of __vSphere API 8.0.2.0__.  Use CPU allocation in *Vcenter.NamespaceManagement.VirtualMachineClasses.UpdateSpec.config_spec* instead to reserve CPUs for a virtual machine.   The percentage of total available CPUs reserved for a virtual machine. We multiply this percentage by the minimum frequency amongst all the cluster nodes to get the CPU reservation that is specified to vSphere in MHz.  This property was added in __vSphere API 7.0.2.00100__.  If missing or &#x60;null&#x60;, no CPU reservation is requested for the virtual machine. | [optional] 
**MemoryMb** | **long** | The amount of memory in MB configured for virtual machine of this class.  This property was added in __vSphere API 7.0.2.00100__.  If missing or &#x60;null&#x60; the current value the will not be modified. | [optional] 
**MemoryReservation** | **long** | This property is deprecated as of __vSphere API 8.0.2.0__.  Use memory allocation in *Vcenter.NamespaceManagement.VirtualMachineClasses.UpdateSpec.config_spec* instead to reserve memory for a virtual machine.   The percentage of available memory reserved for a virtual machine of this class. Memory reservation must be set to 100% for VM class with vGPU or Dynamic DirectPath I/O devices.  This property was added in __vSphere API 7.0.2.00100__.  If missing or &#x60;null&#x60;, no memory reservation is requested for virtual machine. | [optional] 
**Description** | **string** | Description for the VM class.  This property was added in __vSphere API 7.0.2.00100__.  If missing or &#x60;null&#x60;, description is not updated. | [optional] 
**Devices** | [**VcenterNamespaceManagementVirtualMachineClassesVirtualDevices**](VcenterNamespaceManagementVirtualMachineClassesVirtualDevices.md) | This property is deprecated as of __vSphere API 8.0.2.0__.  Use device changes in *Vcenter.NamespaceManagement.VirtualMachineClasses.UpdateSpec.config_spec* instead to add vGPU and Dynamic DirectPath I/O virtual devices.   Virtual devices corresponding to the VM class.  This property was added in __vSphere API 7.0.3.0__.  If missing or &#x60;null&#x60;, virtual devices will not be updated. | [optional] 
**InstanceStorage** | [**VcenterNamespaceManagementVirtualMachineClassesInstanceStorage**](VcenterNamespaceManagementVirtualMachineClassesInstanceStorage.md) | Instance storage associated with the VM class.  This property was added in __vSphere API 8.0.0.0__.  If missing or &#x60;null&#x60;, instance storage specification will not be updated. | [optional] 
**ConfigSpec** | **Object** | A VirtualMachineConfigSpec associated with the VM class.  This property was added in __vSphere API 8.0.2.0__.  If missing or &#x60;null&#x60;, the config spec will not be updated. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

