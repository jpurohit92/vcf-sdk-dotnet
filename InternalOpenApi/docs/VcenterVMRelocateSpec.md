# Vcenter.Automation.OpenApi.Model.VcenterVMRelocateSpec
Document-based relocate spec.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Placement** | [**VcenterVMRelocatePlacementSpec**](VcenterVMRelocatePlacementSpec.md) | Virtual machine placement information.  This property was added in __vSphere API 7.0.0.0__.  If this property is missing or &#x60;null&#x60;, the system will use the values from the source virtual machine. If specified, each field will be used for placement. If the fields result in disjoint placement the operation will fail. If the fields along with the other existing placement of the virtual machine result in disjoint placement the operation will fail. | [optional] 
**Disks** | [**Dictionary&lt;string, VcenterVMDiskRelocateSpec&gt;**](VcenterVMDiskRelocateSpec.md) | Individual disk relocation map.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, all disks will migrate to the datastore specified in the *Vcenter.VM.RelocatePlacementSpec.datastore* property of *Vcenter.VM.RelocateSpec.placement*.  When clients pass a value of this schema as a parameter, the key in the property map must be an identifier for the resource type: &#x60;com.vmware.vcenter.vm.hardware.Disk&#x60;. When operations return a value of this schema as a response, the key in the property map will be an identifier for the resource type: &#x60;com.vmware.vcenter.vm.hardware.Disk&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

