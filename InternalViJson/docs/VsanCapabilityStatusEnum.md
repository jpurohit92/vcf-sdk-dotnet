# Vcenter.ViJson.OpenApi.Model.VsanCapabilityStatusEnum
Represents a condition that an object is in when retrieving capability on it.  A host can be in multiple conditions at the same time. Currently we have the following ones.  Possible values: - `unknown`: Not able to get/calculate the host's capabilities, thus empty capability list returned. - `oldversion`: Host version is before ESXi 6.0 U1. - `disconnected`: Host is in disconnected state. - `calculated`: Capabilities are not retrieved from the host but are calculated based on host's version. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

