# Vcenter.Automation.OpenApi.Model.VapiMetadataPrivilegeComponentInfo
The Vapi.Metadata.Privilege.ComponentInfo schema contains the privilege information of a component element.    For an explanation of privilege information contained within component elements, see *Vapi.Metadata.Privilege.Component*.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Packages** | [**Dictionary&lt;string, VapiMetadataPrivilegePackageInfo&gt;**](VapiMetadataPrivilegePackageInfo.md) | Privilege information of all the package elements. The key in the map is the identifier of the package element and the value in the map is the privilege information for the package element.    For an explanation of privilege information containment within package elements, see *Vapi.Metadata.Privilege.Package*.  When clients pass a value of this schema as a parameter, the key in the property map must be an identifier for the resource type: &#x60;com.vmware.vapi.package&#x60;. When operations return a value of this schema as a response, the key in the property map will be an identifier for the resource type: &#x60;com.vmware.vapi.package&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

