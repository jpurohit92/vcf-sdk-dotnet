# Vcenter.Automation.OpenApi.Model.VcenterVchaClusterPassiveCheckResult
The Vcenter.Vcha.Cluster.Passive.CheckResult schema contains the warnings and errors that will occur during the clone operation.  This schema was added in __vSphere API 6.7.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Warnings** | [**List&lt;VapiStdLocalizableMessage&gt;**](VapiStdLocalizableMessage.md) | A list of problems which may require attention, but which are not fatal.  This property was added in __vSphere API 6.7.1__. | 
**Errors** | [**List&lt;VapiStdLocalizableMessage&gt;**](VapiStdLocalizableMessage.md) | A list of problems which are fatal to the operation and the operation will fail.  This property was added in __vSphere API 6.7.1__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

