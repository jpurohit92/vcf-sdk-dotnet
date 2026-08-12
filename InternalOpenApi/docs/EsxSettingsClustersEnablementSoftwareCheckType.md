# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersEnablementSoftwareCheckType
The Esx.Settings.Clusters.Enablement.Software.CheckType enumerated type contains various checks to identify the possibility to enable the feature that manages the cluster with a single software specification.  Possible values:   - `SOFTWARE`: Perform host software check. This check is to report standalone VIBs (VIBs which are not part of any component) and the features on the given cluster that cannot coexist with the feature which manages the cluster with a single software specification.   - `VERSION`: Perform host version check. This feature does not support hosts with version less than XYZ.   - `STATELESSNESS`: Perform host statelessness check. This feature does not support stateless hosts.   - `VUM_REMEDIATION`: Perform VUM active remediation check.   - `SOFTWARE_SPECIFICATION_EXISTENCE`: Perform cluster's software specification existence check.   - `VSAN_WITNESS_ELIGIBILITY`: Checks to verify if the cluster software specification can be used to manage any vSAN witness hosts in the cluster.  This constant was added in __vSphere API 7.0.2.1__.   This enumeration was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

