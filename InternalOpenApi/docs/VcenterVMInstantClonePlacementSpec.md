# Vcenter.Automation.OpenApi.Model.VcenterVMInstantClonePlacementSpec
The Vcenter.VM.InstantClonePlacementSpec schema contains information used to place an InstantClone of a virtual machine onto resources within the vCenter inventory.  This schema was added in __vSphere API 6.7.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Folder** | **string** | Virtual machine folder into which the InstantCloned virtual machine should be placed.  This property was added in __vSphere API 6.7.1__.  If property is missing or &#x60;null&#x60;, the system will use the virtual machine folder of the source virtual machine.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;Folder&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;Folder&#x60;. | [optional] 
**ResourcePool** | **string** | Resource pool into which the InstantCloned virtual machine should be placed.  This property was added in __vSphere API 6.7.1__.  If property is missing or &#x60;null&#x60;, the system will use the resource pool of the source virtual machine.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;ResourcePool&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;ResourcePool&#x60;. | [optional] 
**Datastore** | **string** | Datastore on which the InstantCloned virtual machine&#39;s configuration state should be stored. This datastore will also be used for any virtual disks that are created as part of the virtual machine InstantClone operation.  This property was added in __vSphere API 6.7.1__.  If property is missing or &#x60;null&#x60;, the system will use the datastore of the source virtual machine.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;Datastore&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;Datastore&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

