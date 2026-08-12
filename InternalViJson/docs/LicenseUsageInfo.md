# Vcenter.ViJson.OpenApi.Model.LicenseUsageInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Source** | [**LicenseSource**](LicenseSource.md) | The source from which licensing data is acquired.  See also *LicenseSource*.  | 
**SourceAvailable** | **bool** | Returns whether or not the source is currently available.  See also *LicenseManager.sourceAvailable*.  | 
**ReservationInfo** | [**List&lt;LicenseReservationInfo&gt;**](LicenseReservationInfo.md) | A list of feature reservations.  | [optional] 
**FeatureInfo** | [**List&lt;LicenseFeatureInfo&gt;**](LicenseFeatureInfo.md) | Includes all the features that are referenced in the reservation array.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

