# Vcenter.Automation.OpenApi.Model.VapiMetadataPrivilegePackageInfo
The Vapi.Metadata.Privilege.PackageInfo schema contains the privilege information of a package element.    For an explanation of privilege information contained within package elements, see *Vapi.Metadata.Privilege.Package*.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Privileges** | **List&lt;string&gt;** | List of default privileges to be used for all the operations present in this package. If a particular operation element has no explicit privileges defined in the privilege definition file, these privileges are used for enforcing authorization. | 
**Services** | [**Dictionary&lt;string, VapiMetadataPrivilegeServiceInfo&gt;**](VapiMetadataPrivilegeServiceInfo.md) | Information about all service elements contained in this package element that contain privilege information. The key in the map is the identifier of the service element and the value in the map is the privilege information for the service element.    For an explanation of privilege information containment within service elements, see *Vapi.Metadata.Privilege.Service*.  When clients pass a value of this schema as a parameter, the key in the property map must be an identifier for the resource type: &#x60;com.vmware.vapi.service&#x60;. When operations return a value of this schema as a response, the key in the property map will be an identifier for the resource type: &#x60;com.vmware.vapi.service&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

