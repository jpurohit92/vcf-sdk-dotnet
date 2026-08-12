# Vcenter.Automation.OpenApi.Model.VcenterGuestCustomizationSpecsFilterSpec
The Vcenter.Guest.CustomizationSpecs.FilterSpec schema contains properties used to filter the results when listing guest customization specifications (see *GET /vcenter/guest/customization-specs*). If multiple properties are specified, only guest customization specifications matching all of the properties match the filter.  This schema was added in __vSphere API 6.7.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OsType** | **string** | Guest operating system type that guest customization specifications must have to match the filter (see *Vcenter.Guest.CustomizationSpecs.Summary.OS_type*).  Possible values:   - &#x60;WINDOWS&#x60;: A customization specification for a Windows guest operating system   - &#x60;LINUX&#x60;: A customization specification for a Linux guest operating system   For more information see: *Vcenter.Guest.CustomizationSpecs.OsType*.  This property was added in __vSphere API 6.7.1__.  If missing or &#x60;null&#x60;, guest customization specifications with any guest operating system type match the filter. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

