# Vcenter.Automation.OpenApi.Model.VcenterOvfLibraryItemCreateSpec
The Vcenter.Ovf.LibraryItem.CreateSpec schema defines the information used to create or update a library item containing an OVF package.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name to use in the OVF descriptor stored in the library item.  If missing or &#x60;null&#x60;, the server will use source&#39;s current name. | [optional] 
**Description** | **string** | Description to use in the OVF descriptor stored in the library item.  If missing or &#x60;null&#x60;, the server will use source&#39;s current annotation. | [optional] 
**Flags** | **List&lt;string&gt;** | Flags to use for OVF package creation. The supported flags can be obtained using *GET /vcenter/ovf/export-flag*.  If missing or &#x60;null&#x60;, no flags will be used. | [optional] 
**LibraryItemSourceId** | **string** | Source identifier of the library item for image identification.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, no source identifier will be used.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.content.library.Item&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.content.library.Item&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

