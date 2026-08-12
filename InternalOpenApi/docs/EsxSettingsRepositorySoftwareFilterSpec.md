# Vcenter.Automation.OpenApi.Model.EsxSettingsRepositorySoftwareFilterSpec
The Esx.Settings.Repository.Software.FilterSpec schema contains properties used to filter the results when listing software specifications in repository. (see *GET /esx/settings/repository/software*).  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Owners** | **List&lt;string&gt;** | Filter software specification in repository based on the image owners.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, the filter will match all the owners. | [optional] 
**DisplayNames** | **List&lt;string&gt;** | Filter software specification in repository based on the display names.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, the filter will match all the display names. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

