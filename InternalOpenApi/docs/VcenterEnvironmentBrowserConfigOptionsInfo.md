# Vcenter.Automation.OpenApi.Model.VcenterEnvironmentBrowserConfigOptionsInfo
The Vcenter.EnvironmentBrowser.ConfigOptions.Info schema contain the vim.vm.ConfigOption specifying the available options for executing virtual machines on a set of clusters. The result is contained in a vim.vm.ConfigOption data structure.  This schema was added in __vSphere API 8.0.2.00300__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConfigOption** | **Object** | A vim.vm.ConfigOption data structure.  This property was added in __vSphere API 8.0.2.00300__.  may be missing or &#x60;null&#x60; if none of the clusters specified in the #get operation contained a vim.vm.ConfigOption that matched the requested key and/or guest IDs. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

