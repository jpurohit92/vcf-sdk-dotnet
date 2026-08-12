# Vcenter.Automation.OpenApi.Model.EsxSettingsHostsEnablementSoftwareCheckSpec
The Esx.Settings.Hosts.Enablement.Software.CheckSpec schema contains information describing what checks should be performed.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChecksToSkip** | **List&lt;string&gt;** | Specifies the checks that should be skipped. If the set is empty, all checks will be performed.  Possible values:   - &#x60;SOFTWARE&#x60;: Perform host software check. The purpose of this check is to report standalone VIBs (VIBs which are not part of any component).   - &#x60;VERSION&#x60;: Perform host version check. This feature does not support hosts with version less than XYZ.   - &#x60;STATELESSNESS&#x60;: Perform host statelessness check. This feature does not support stateless hosts.   - &#x60;VUM_REMEDIATION&#x60;: Perform VUM active remediation check.   - &#x60;SOFTWARE_SPECIFICATION_EXISTENCE&#x60;: Perform host&#39;s software specification existence check.   - &#x60;VSAN_WITNESS_ELIGIBILITY&#x60;: Perform vSAN witness check to verify if the standalone host acting as a vSAN witness can be managed with a software image.   For more information see: *Esx.Settings.Hosts.Enablement.Software.CheckType*.  This property was added in __vSphere API 8.0.0.1__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

