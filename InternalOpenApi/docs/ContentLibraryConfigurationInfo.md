# Vcenter.Automation.OpenApi.Model.ContentLibraryConfigurationInfo
The Content.Library.ConfigurationInfo represents the configuration at individual Content Library level and applies to all types of libraries.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApplyLibraryUsageToItems** | **bool** | This configuration indicates whether usage tracking at the library level declared via com.vmware.content.library.Usage#add API should also apply to individual items within the library.    If set to &#x60;true&#x60;, library usage will also be propagated to its items and if the library is currently being used by other resources, deletion of any item in the library will also be blocked unless the library is forcefully deleted.     If set to &#x60;false&#x60; (default), library item deletions are allowed even if the library is currently being used by other resources. In this case, only the deletion of the library itself is blocked when library usage exists.     This configuration in effect guards the local/published library item deletion as the subscribed library item cannot be deleted directly.   This property was added in __vSphere API 9.1.0.0__.  This property is optional for the &#x60;create&#x60; operation. It will always be present in the response of the &#x60;get&#x60; or &#x60;list&#x60; operations. It is optional for the &#x60;update&#x60; operation. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

