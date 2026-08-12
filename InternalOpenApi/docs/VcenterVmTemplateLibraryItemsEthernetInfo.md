# Vcenter.Automation.OpenApi.Model.VcenterVmTemplateLibraryItemsEthernetInfo
The Vcenter.VmTemplate.LibraryItems.EthernetInfo schema contains information about a virtual machine template's virtual Ethernet adapter.  This schema was added in __vSphere API 6.8__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BackingType** | **string** | Network backing type for the virtual Ethernet adapter.  Possible values:   - &#x60;STANDARD_PORTGROUP&#x60;: vSphere standard portgroup network backing.   - &#x60;HOST_DEVICE&#x60;: Legacy host device network backing. Imported VMs may have virtual Ethernet adapters with this type of backing, but this type of backing cannot be used to create or to update a virtual Ethernet adapter.   - &#x60;DISTRIBUTED_PORTGROUP&#x60;: Distributed virtual switch backing.   - &#x60;OPAQUE_NETWORK&#x60;: Opaque network backing.   For more information see: *Vcenter.VmTemplate.LibraryItems.EthernetInfo.NetworkBackingType*.  This property was added in __vSphere API 6.8__. | 
**MacType** | **string** | MAC address type of the ethernet adapter.  Possible values:   - &#x60;MANUAL&#x60;: MAC address is assigned statically.   - &#x60;GENERATED&#x60;: MAC address is generated automatically.   - &#x60;ASSIGNED&#x60;: MAC address is assigned by vCenter Server.   For more information see: *Vcenter.VmTemplate.LibraryItems.EthernetInfo.MacAddressType*.  This property was added in __vSphere API 6.8__. | 
**Network** | **string** | Identifier of the network backing the virtual Ethernet adapter.  This property was added in __vSphere API 6.8__.  This property will be missing or &#x60;null&#x60; if the identifier of the network backing could not be determined.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;Network&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;Network&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

