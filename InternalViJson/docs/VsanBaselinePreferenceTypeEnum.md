# Vcenter.ViJson.OpenApi.Model.VsanBaselinePreferenceTypeEnum
Represents various baseline preference types.  Any patch or update release is considered part of the same \"release family\", while both updates to the major version number (e.g. 7.0) or to the minor version number (e.g. 7.1) would be considered different \"release families\".  Possible values: - `latestRelease`: recommend latest release compatible with cluster hardware, it could be either new major release or update release in current release family.      (eg. Consider ESXi 6.8 is released and current installed version is ESXi 6.7, then ESXi 6.8 would be recommended under this mode if hardware is compatible.) - `latestPatch`: latest patch contains all bug fixes and updates for the current release family.      In this mode recommendation engine wouldn't jump to other release family. (eg. Consider ESXi 6.8 is released and current installed version is ESXi 6.7, then ESXi 6.7 U1 instead of ESXi 6.8 would be recommended under this mode if hardware is compatible.) - `noRecommendation`: do not generate baseline recommendation for current vSAN cluster. - `VsanBaselinePreferenceType_Unknown` 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

