# Vcenter.Automation.OpenApi.Model.VcenterVmTemplateLibraryItemsCheckOutsCheckOutSpec
The Vcenter.VmTemplate.LibraryItems.CheckOuts.CheckOutSpec schema defines the information required to check out a library item containing a virtual machine template.  This schema was added in __vSphere API 6.9.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the virtual machine to check out of the library item.  This property was added in __vSphere API 6.9.1__.  This property is currently required. In the future, if this property is missing or &#x60;null&#x60;, the system will choose a suitable name for the virtual machine. | [optional] 
**Placement** | [**VcenterVmTemplateLibraryItemsCheckOutsPlacementSpec**](VcenterVmTemplateLibraryItemsCheckOutsPlacementSpec.md) | Information used to place the checked out virtual machine.  This property was added in __vSphere API 6.9.1__.  This property is currently required. In the future, if this property is missing or &#x60;null&#x60;, the system will place the virtual machine on a suitable resource.    If specified, each property will be used for placement. If the properties result in disjoint placement, the operation will fail. If the properties along with the placement values of the source virtual machine template result in disjoint placement, the operation will fail.  | [optional] 
**PoweredOn** | **bool** | Specifies whether the virtual machine should be powered on after check out.  This property was added in __vSphere API 6.9.1__.  If missing or &#x60;null&#x60;, the virtual machine will not be powered on after check out. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

