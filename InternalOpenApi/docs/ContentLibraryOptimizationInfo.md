# Vcenter.Automation.OpenApi.Model.ContentLibraryOptimizationInfo
The Content.Library.OptimizationInfo schema defines different optimizations and optimization parameters applied to particular library.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OptimizeRemotePublishing** | **bool** | If set to &#x60;true&#x60; then library would be optimized for remote publishing.    Turn it on if remote publishing is dominant use case for this library. Remote publishing means here that publisher and subscribers are not the part of the same Vcenter SSO domain.    Any optimizations could be done as result of turning on this optimization during library creation. For example, library content could be stored in different format but optimizations are not limited to just storage format.    Note, that value of this toggle could be set only during creation of the library and you would need to migrate your library in case you need to change this value (optimize the library for different use case).  This property is optional for the &#x60;create&#x60; operation. If not specified for the &#x60;create&#x60;, the default is for the library to not be optmized for specific use case. It is not used for the &#x60;update&#x60; operation. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

