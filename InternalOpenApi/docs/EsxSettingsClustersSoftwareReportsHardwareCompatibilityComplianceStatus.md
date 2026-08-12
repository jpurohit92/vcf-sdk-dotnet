# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersSoftwareReportsHardwareCompatibilityComplianceStatus
The Esx.Settings.Clusters.Software.Reports.HardwareCompatibility.ComplianceStatus enumerated type contains the possible different status of compliance with respect to target version.  Possible values:   - `COMPATIBLE`: Target hardware is compliant with BCG/HCL. This includes (from the *Esx.Settings.Clusters.Software.Reports.ComplianceStatusDetail*:          - COMPLIANT      - VENDOR_UPDATE      - USER_OVERRIDE     - `INCOMPATIBLE`: Target hardware is not (recognizably) compliant with BCG/HCL This includes (from the *Esx.Settings.Clusters.Software.Reports.ComplianceStatusDetail*):          - NONCOMPLIANT      - USER_FLAGGED      - NONCOMPLIANCE_MUTED     - `HCL_DATA_UNAVAILABLE`: Never returned by the HCL compliance APIs  HCL data can not be fetched to validate cluster hardware.   - `UNAVAILABLE`: Target hardware compliance with BCG/HCL cannot be determined This includes (from the *Esx.Settings.Clusters.Software.Reports.ComplianceStatusDetail*):          - HCL_DATA_UNAVAILABLE      - UNAVAILABLE      - NO_FIRMWARE_PROVIDER      - UNKNOWN     - `NO_FIRMWARE_PROVIDER`: Never returned by the HCL compliance APIs  No Firmware HSM present in Software Spec to get Firmware Details *Esx.Settings.HardwareSupportPackageInfo* schema   This enumeration was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

