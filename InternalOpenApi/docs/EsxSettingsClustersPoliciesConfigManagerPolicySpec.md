# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersPoliciesConfigManagerPolicySpec
This specification defines the settings to manage the *POST /esx/settings/clusters/{cluster}/configuration?action=apply* API behaviour.  This schema was added in __vSphere API 8.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SerialRemediation** | **bool** | Specifies whether the hosts in the cluster should be serially remediated.  This property was added in __vSphere API 8.0.3.0__.  If missing or &#x60;null&#x60;, configured values will be unset. | [optional] 
**AutoRemediateOnHostAdd** | **bool** | Specifies whether newly added hosts in the cluster will be automatically remediated.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, the configured value will be false. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

