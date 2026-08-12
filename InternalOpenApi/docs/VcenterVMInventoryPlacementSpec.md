# Vcenter.Automation.OpenApi.Model.VcenterVMInventoryPlacementSpec
The Vcenter.VM.InventoryPlacementSpec schema contains information used to place a virtual machine in the vCenter inventory.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Folder** | **string** | Virtual machine folder into which the virtual machine should be placed.  This property is currently required. In the future, if this property is missing or &#x60;null&#x60;, the system will attempt to choose a suitable folder for the virtual machine; if a folder cannot be chosen, the virtual machine creation operation will fail.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;Folder&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;Folder&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

