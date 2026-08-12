# Vcenter.Automation.OpenApi.Model.VcenterContentRegistriesHarborProjectsSummary
This schema is deprecated as of __vSphere API 8.0.1.00200__.  The Vcenter.Content.Registries.Harbor.Projects.Summary schema contains basic information about a Harbor project.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Project** | **string** | This property is deprecated as of __vSphere API 8.0.1.00200__.  Identifier of the harbor project.  This property was added in __vSphere API 7.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.content.Registry.Harbor.Project&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.content.Registry.Harbor.Project&#x60;. | 
**Name** | **string** | This property is deprecated as of __vSphere API 8.0.1.00200__.  Name of the Harbor project. Should be between 1-63 characters long alphanumeric string and may contain the following characters: a-z,0-9, and &#39;-&#39;. Must be starting with characters or numbers, with the &#39;-&#39; character allowed anywhere except the first or last character.  This property was added in __vSphere API 7.0.0.0__. | 
**Scope** | **string** | This property is deprecated as of __vSphere API 8.0.1.00200__.  Access type of a Harbor project.  Possible values:   - &#x60;PUBLIC&#x60;: A Harbor project can be accessed by everyone.   - &#x60;PRIVATE&#x60;: A Harbor project can only be accessed by assigned users.   For more information see: *Vcenter.Content.Registries.Harbor.Projects.Scope*.  This property was added in __vSphere API 7.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

