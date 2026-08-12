# Vcenter.Automation.OpenApi.Model.VcenterOvfOvfWarning
The Vcenter.Ovf.OvfWarning schema describes a warning related to accessing, validating, deploying, or exporting an OVF package.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Category** | **string** | The message category.  Possible values:   - &#x60;VALIDATION&#x60;: The OVF descriptor is invalid, for example, syntax errors or schema errors.   - &#x60;INPUT&#x60;: The user provided input parameters are invalid.   - &#x60;SERVER&#x60;: Server error.   For more information see: *Vcenter.Ovf.OvfMessage.Category*. | 
**Issues** | [**List&lt;VcenterOvfParseIssue&gt;**](VcenterOvfParseIssue.md) | List of parse issues (see *Vcenter.Ovf.ParseIssue*).  This property is optional and it is only relevant when the value of category is *Vcenter.Ovf.OvfMessage.Category.VALIDATION*. | [optional] 
**Name** | **string** | The name of input parameter.  This property is optional and it is only relevant when the value of category is *Vcenter.Ovf.OvfMessage.Category.INPUT*. | [optional] 
**Value** | **string** | The value of input parameter.  This property is optional and it is only relevant when the value of category is *Vcenter.Ovf.OvfMessage.Category.INPUT*. | [optional] 
**Message** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | A localizable message.  This property is optional and it is only relevant when the value of category is *Vcenter.Ovf.OvfMessage.Category.INPUT*. | [optional] 
**Error** | [**VapiStdErrorsError**](VapiStdErrorsError.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

