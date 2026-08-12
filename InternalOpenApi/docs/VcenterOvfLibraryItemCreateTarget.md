# Vcenter.Automation.OpenApi.Model.VcenterOvfLibraryItemCreateTarget
The Vcenter.Ovf.LibraryItem.CreateTarget schema specifies the target library item when capturing a virtual machine or virtual appliance as an OVF package in a library item in a content library. The target can be an existing library item, which will be updated, creating a new version, or it can be a newly created library item in a specified library. See *POST /vcenter/ovf/library-item*.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LibraryId** | **string** | Identifier of the library in which a new library item should be created. This property is not used if the library_item_id property is specified.  This property is currently required.    In the future, if missing or &#x60;null&#x60;, the library_item_id property must be specified.   When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.content.Library&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.content.Library&#x60;. | [optional] 
**LibraryItemId** | **string** | Identifier of the library item that should be updated.  If missing or &#x60;null&#x60;, a new library item will be created. The library_id property must be specified if this property is set.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.content.library.Item&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.content.library.Item&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

