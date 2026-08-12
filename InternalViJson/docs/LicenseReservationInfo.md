# Vcenter.ViJson.OpenApi.Model.LicenseReservationInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | Key of the License Feature.  See also *LicenseFeatureInfo.key*.  | 
**State** | **LicenseReservationInfoStateEnum** | Describes the reservation state of a license.  | 
**Required** | **int** | Contains the required number of licenses of the particular type that the product needs in its current configuration.  Licenses are normally allocated at the same time as they are needed, so the value of required is set at the time the license is needed. For example, in the case of the number of licenses based on virtual machines, the required count is set at the time a virtual machine is powered on, just before the license is checked out.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

