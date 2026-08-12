# Vcenter.Automation.OpenApi.Model.VcenterGuestCustomizationSpecsSummary
The Vcenter.Guest.CustomizationSpecs.Summary schema contains commonly used information about a guest customization specification.  This schema was added in __vSphere API 6.7.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the guest customization specification.  This property was added in __vSphere API 6.7.1__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.guest.CustomizationSpec&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.guest.CustomizationSpec&#x60;. | 
**Description** | **string** | Description of the guest customization specification.  This property was added in __vSphere API 6.7.1__. | 
**OsType** | **string** | Guest operating system type for which that this guest customization specification applies.  Possible values:   - &#x60;WINDOWS&#x60;: A customization specification for a Windows guest operating system   - &#x60;LINUX&#x60;: A customization specification for a Linux guest operating system   For more information see: *Vcenter.Guest.CustomizationSpecs.OsType*.  This property was added in __vSphere API 6.7.1__. | 
**LastModified** | **DateTime** | Date and time when this guest customization specification was last modified.  This property was added in __vSphere API 6.7.1__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

