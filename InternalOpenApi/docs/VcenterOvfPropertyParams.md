# Vcenter.Automation.OpenApi.Model.VcenterOvfPropertyParams
The Vcenter.Ovf.PropertyParams schema contains a list of OVF properties that can be configured when the OVF package is deployed.    This is based on the ovf:ProductSection.    See *POST /vcenter/ovf/library-item/{ovfLibraryItemId}?action=deploy* and *POST /vcenter/ovf/library-item/{ovfLibraryItemId}?action=filter*.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Properties** | [**List&lt;VcenterOvfProperty&gt;**](VcenterOvfProperty.md) | List of OVF properties.  This property is optional in the input parameters when deploying an OVF package. This property will always be present in the result when retrieving information about an OVF package. | [optional] 
**Type** | **string** | Unique identifier describing the type of the OVF parameters. The value is the name of the OVF parameters schema.  This property must be provided in the input parameters when deploying an OVF package. This property will always be present in the result when retrieving information about an OVF package. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

