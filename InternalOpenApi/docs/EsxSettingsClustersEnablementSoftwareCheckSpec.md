# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersEnablementSoftwareCheckSpec
The Esx.Settings.Clusters.Enablement.Software.CheckSpec schema contains information describing what checks should be performed.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChecksToSkip** | **List&lt;string&gt;** | Specifies the checks that should be skipped. If the set is empty, all checks will be performed.  Possible values:   - &#x60;SOFTWARE&#x60;: Perform host software check. This check is to report standalone VIBs (VIBs which are not part of any component) and the features on the given cluster that cannot coexist with the feature which manages the cluster with a single software specification.   - &#x60;VERSION&#x60;: Perform host version check. This feature does not support hosts with version less than XYZ.   - &#x60;STATELESSNESS&#x60;: Perform host statelessness check. This feature does not support stateless hosts.   - &#x60;VUM_REMEDIATION&#x60;: Perform VUM active remediation check.   - &#x60;SOFTWARE_SPECIFICATION_EXISTENCE&#x60;: Perform cluster&#39;s software specification existence check.   - &#x60;VSAN_WITNESS_ELIGIBILITY&#x60;: Checks to verify if the cluster software specification can be used to manage any vSAN witness hosts in the cluster.  This constant was added in __vSphere API 7.0.2.1__.   For more information see: *Esx.Settings.Clusters.Enablement.Software.CheckType*.  This property was added in __vSphere API 7.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

