# Vcenter.Automation.OpenApi.Model.VcenterOvfTagParams
The Vcenter.Ovf.TagParams schema contains information required to attach tags while deploying a VM.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Tags** | [**List&lt;VcenterOvfTagSpec&gt;**](VcenterOvfTagSpec.md) | List of tag parameters which contains information required to attach tags while deploying a VM.  This property was added in __vSphere API 9.1.0.0__.  This property is not used for the &#x60;create&#x60; operation. It will always be present in the response of the &#x60;get&#x60; or &#x60;list&#x60; operations. It is not used for the &#x60;update&#x60; operation. | [optional] 
**Type** | **string** | Unique identifier describing the type of the OVF parameters. The value is the name of the OVF parameters schema.  This property must be provided in the input parameters when deploying an OVF package. This property will always be present in the result when retrieving information about an OVF package. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

