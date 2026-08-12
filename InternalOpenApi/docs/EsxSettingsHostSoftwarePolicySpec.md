# Vcenter.Automation.OpenApi.Model.EsxSettingsHostSoftwarePolicySpec
This Esx.Settings.HostSoftwarePolicySpec schema contains properties that define the settings to manage the behaviour of the *POST /esx/settings/hosts/{host}/software?action=apply* API.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SkipReservedVibsCaching** | **bool** | Skip caching of reserved VIBs on the host. During effective VIB computation, a VIB at a lower version can get replaced by the same VIB at a higher version coming from another release unit. vLCM caches the lower version VIB in ESX-OSData partition to support extraction of currently running image from the hosts. Setting this option means (a) remediation will not cache reserved VIBs, (b) extracting the currently running image from such hosts will not include the reserved VIBs. Hence, the image will not be complete and that might lead to remediation failures.   NOTE: Use this option with caution.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, reserved VIBs will be cached. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

