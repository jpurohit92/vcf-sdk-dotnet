# Vcenter.Automation.OpenApi.Model.ContentLibraryStateInfo
The *Content.Library.StateInfo* schema provides the information about the state of a content library.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**State** | **string** | The state (StateInfo.State) of this library.    This property is not used for the &#x60;create&#x60; and &#x60;update&#x60; operations. It will always be present in the result of a &#x60;get&#x60; operation.  Possible values:   - &#x60;ACTIVE&#x60;: This is default library state when library is created. The library is fully functional when in this state.   - &#x60;MAINTENANCE&#x60;: This state indicates that the library is in maintenance. Any operations that alter the Library content or its use are restricted.   For more information see: *Content.Library.StateInfo.State*.  This property was added in __vSphere API 9.0.0.0__.  This property is not used for the &#x60;create&#x60; operation. It will always be present in the response of the &#x60;get&#x60; or &#x60;list&#x60; operations. It is not used for the &#x60;update&#x60; operation. | [optional] 
**Message** | **string** | The property specifies the reason for the library&#39;s change from one state to another or some information about the current state.  This property was added in __vSphere API 9.1.0.0__.  If unset, the information on the state change is not recorded. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

