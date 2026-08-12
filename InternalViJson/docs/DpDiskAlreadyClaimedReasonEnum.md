# Vcenter.ViJson.OpenApi.Model.DpDiskAlreadyClaimedReasonEnum
Enumeration of reason codes representing why backend needs to report the disk being claimed already.  Possible values: - `maxVendorsExceeded`: The disk is already protected by the maximum number of vendors supported by the corresponding DPD. - `alreadyInUse`: The disk is already protected by the same vendor when a new protection request from the same vendor is received, or the allocation limit is reached for the vendor attempting to claim the disk. - `diskAlreadyClaimedReasonUnknown`: A fallback value used when a client sees an unknown DiskAlreadyClaimedReason. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

