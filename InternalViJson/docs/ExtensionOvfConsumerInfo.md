# Vcenter.ViJson.OpenApi.Model.ExtensionOvfConsumerInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CallbackUrl** | **string** | Callback url for the OVF consumer.  This URL must point to a SOAP API implementing the OVF consumer interface.  Example: https://extension-host:8081/  This callback is for internal use only.  | 
**SectionType** | **List&lt;string&gt;** | A list of fully qualified OVF section types that this consumer handles.  Fully qualified means that each section type must be prefixed with its namespace enclosed in curly braces. See the examples below.  An InvalidArgument error is thrown if there is overlap between OVF consumers, meaning that the same section type appears in the sectionType list of more than one OVF consumer.  Example: \\[ \&quot;{http://www.vmware.com/schema/vServiceManager}vServiceDependency\&quot;, \&quot;{http://www.vmware.com/schema/vServiceManager}vServiceBinding\&quot; \\]  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

