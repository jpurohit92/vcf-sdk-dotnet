# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersConfigurationDriftReviewPolicy
The policy that is used to review the drift. The policy can have a number of options in possibleValues if the value type is set as enum and one of the options will be set in value and used in the solution apply operation. If the valueType is set as other value. The corresponding value field will be set.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Possible values:   - &#x60;ENUM&#x60;   - &#x60;STRING&#x60;   - &#x60;LONG&#x60;   - &#x60;BOOLEAN&#x60;   For more information see: *Esx.Settings.Clusters.Configuration.DriftReviewPolicy.ValueType*.  This property was added in __vSphere API 9.1.0.0__. | 
**Name** | **string** | The name of the policy.  This property was added in __vSphere API 9.1.0.0__. | 
**PossibleValues** | **List&lt;string&gt;** | A set of possible values.  This property was added in __vSphere API 9.1.0.0__.  This property is optional and it is only relevant when the value of type is *Esx.Settings.Clusters.Configuration.DriftReviewPolicy.ValueType.ENUM*. | [optional] 
**ValueString** | **string** | This property was added in __vSphere API 9.1.0.0__.  This property is optional and it is only relevant when the value of type is one of *Esx.Settings.Clusters.Configuration.DriftReviewPolicy.ValueType.ENUM* or *Esx.Settings.Clusters.Configuration.DriftReviewPolicy.ValueType.STRING*. | [optional] 
**ValueLong** | **long** | This property was added in __vSphere API 9.1.0.0__.  This property is optional and it is only relevant when the value of type is *Esx.Settings.Clusters.Configuration.DriftReviewPolicy.ValueType.LONG*. | [optional] 
**ValueBoolean** | **bool** | This property was added in __vSphere API 9.1.0.0__.  This property is optional and it is only relevant when the value of type is *Esx.Settings.Clusters.Configuration.DriftReviewPolicy.ValueType.BOOLEAN*. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

