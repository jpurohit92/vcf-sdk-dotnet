# Vcenter.Automation.OpenApi.Model.VcenterOvfUnknownSectionParams
The Vcenter.Ovf.UnknownSectionParams schema contains a list of unknown, non-required sections.    See *POST /vcenter/ovf/library-item/{ovfLibraryItemId}?action=deploy* and *POST /vcenter/ovf/library-item/{ovfLibraryItemId}?action=filter*.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UnknownSections** | [**List&lt;VcenterOvfUnknownSection&gt;**](VcenterOvfUnknownSection.md) | List of unknown, non-required sections.  This property is not used in the input parameters when deploying an OVF package. This property will always be present in the result when retrieving information about an OVF package. | [optional] 
**Type** | **string** | Unique identifier describing the type of the OVF parameters. The value is the name of the OVF parameters schema.  This property must be provided in the input parameters when deploying an OVF package. This property will always be present in the result when retrieving information about an OVF package. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

