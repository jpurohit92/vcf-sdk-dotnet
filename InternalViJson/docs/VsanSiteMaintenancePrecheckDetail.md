# Vcenter.ViJson.OpenApi.Model.VsanSiteMaintenancePrecheckDetail

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TestName** | **string** | The name of the precheck test item.  | 
**TestStatus** | **string** | The result of the precheck item.  Possible values are: - \&quot;green\&quot;: The test passed with no issues. - \&quot;yellow\&quot;: The test passed with warnings. There are non-critical issues   that should be reviewed before proceeding. - \&quot;red\&quot;: The test failed due to critical issues that must be resolved.    Site Maintenance Operation Criteria: - When all test results are \&quot;green\&quot;: The fault domain maintenance operation can proceed   and is expected to complete successfully. - When test results include \&quot;yellow\&quot;: The fault domain maintenance operation can proceed,   but administrators should review the warnings and understand potential impacts. - When any test result is \&quot;red\&quot;: The fault domain maintenance operation cannot proceed   until the critical issues are resolved.  | 
**Message** | [**LocalizableMessage**](LocalizableMessage.md) | Informative and localizable messages providing details about the test result.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

