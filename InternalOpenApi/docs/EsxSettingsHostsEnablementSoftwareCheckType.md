# Vcenter.Automation.OpenApi.Model.EsxSettingsHostsEnablementSoftwareCheckType
The Esx.Settings.Hosts.Enablement.Software.CheckType enumerated type contains various checks to identify the possibility to enable the feature that manages the host with a single software specification.  Possible values:   - `SOFTWARE`: Perform host software check. The purpose of this check is to report standalone VIBs (VIBs which are not part of any component).   - `VERSION`: Perform host version check. This feature does not support hosts with version less than XYZ.   - `STATELESSNESS`: Perform host statelessness check. This feature does not support stateless hosts.   - `VUM_REMEDIATION`: Perform VUM active remediation check.   - `SOFTWARE_SPECIFICATION_EXISTENCE`: Perform host's software specification existence check.   - `VSAN_WITNESS_ELIGIBILITY`: Perform vSAN witness check to verify if the standalone host acting as a vSAN witness can be managed with a software image.   This enumeration was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

