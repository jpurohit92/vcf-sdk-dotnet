# Vcenter.ViJson.OpenApi.Model.VsanFileServicePreflightCheckScopeEnum
Enumeration of preflight check scope.  Possible values: - `basic`: Scope indicates preflight check covers:   - Network partition check   - vSAN datastore presence to each host   - The versions of the ESXi hosts match in this cluster   - NTP configuration check in ESXi hosts if vSAN file service version is 8.0 or newer   - Domain configuration format check   - Running OVF information check   - If a DVS portgroup is passed as network, it checks if DVS version is older than 6.6 - `advanced`: Scope indicates preflight check covers:   - Checks covered in 'basic' scope   - File server domain configuration validation in live environment when vSAN file service has been enabled - `FileServicePreflightCheckScope_Unknown`: represents the value when the lower version client cannot recognize the enum value. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

