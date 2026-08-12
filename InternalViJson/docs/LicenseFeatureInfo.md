# Vcenter.ViJson.OpenApi.Model.LicenseFeatureInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | Unique identifier for license as defined in License source data.  Max length of this string is 64 characters of ASCII/ISO Latin-1 character set.  | 
**FeatureName** | **string** | The display string for the feature name.  | 
**FeatureDescription** | **string** | A human readable description of what function this feature enables.  | [optional] 
**State** | **LicenseFeatureInfoStateEnum** | Describes the state of the feature based on the current edition license.  This property is unset for an edition license.  | [optional] 
**CostUnit** | **string** | Each license has a cost associated with it and the value of costUnit specifies the applicable unit.  See also *LicenseFeatureInfoUnit_enum*.  | 
**SourceRestriction** | **string** | Describe any restriction on the source of a license for this feature.  See also *LicenseFeatureInfoSourceRestriction_enum*.  | [optional] 
**DependentKey** | **List&lt;string&gt;** | Report List of feature keys used by this edition.  | [optional] 
**Edition** | **bool** | Flag to indicate whether the feature is an edition.  | [optional] 
**ExpiresOn** | **DateTime** | Date representing the expiration date  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

