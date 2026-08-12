# Vcenter.ViJson.OpenApi.Model.LicenseDiagnostics

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SourceLastChanged** | **DateTime** | A timestamp of when sourceAvailable last changed state, expressed in UTC.  | 
**SourceLost** | **string** | Counter to track number of times connection to source was lost.  This value starts at zero and wraps at 2^32-1 to zero. Discontinuity: sourceLastChanged.  | 
**SourceLatency** | **float** | Exponentially decaying average of the transaction time for license acquisition and routine communications with LicenseSource.  Units: milliseconds.  | 
**LicenseRequests** | **string** | Counter to track total number of licenses requested.  This value starts at zero and wraps at 2^32-1 to zero. Discontinuity: sourceLastChanged.  | 
**LicenseRequestFailures** | **string** | Counter to track Total number of licenses requests that were not fulfilled (denied, timeout, or other).  This value starts at zero and wraps at 2^32-1 to zero. Discontinuity: sourceLastChanged.  | 
**LicenseFeatureUnknowns** | **string** | Counter to track Total number of license features parsed from License source that are not recognized.  This value starts at zero and wraps at 2^32-1 to zero. Discontinuity: sourceLastChanged.  | 
**OpState** | **LicenseManagerStateEnum** | The general state of the license subsystem.  | 
**LastStatusUpdate** | **DateTime** | A timestamp of when opState was last updated.  | 
**OpFailureMessage** | **string** | A human readable reason when optState reports Fault condition.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

