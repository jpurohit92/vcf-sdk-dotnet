# Vcenter.Automation.OpenApi.Model.VcenterOvfScaleOutParams
The Vcenter.Ovf.ScaleOutParams schema contains information about the scale-out groups described in the OVF package.    When deploying an OVF package, a deployment specific instance count can be specified (see *Vcenter.Ovf.ScaleOutGroup.instance_count*.    This is based on the ovf2:ScaleOutSection.    See *POST /vcenter/ovf/library-item/{ovfLibraryItemId}?action=deploy* and *POST /vcenter/ovf/library-item/{ovfLibraryItemId}?action=filter*.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Groups** | [**List&lt;VcenterOvfScaleOutGroup&gt;**](VcenterOvfScaleOutGroup.md) | The list of scale-out groups.  This property is optional in the input parameters when deploying an OVF package. If missing or &#x60;null&#x60; there are no scale-out groups. This property will always be present in the result when retrieving information about an OVF package. | [optional] 
**Type** | **string** | Unique identifier describing the type of the OVF parameters. The value is the name of the OVF parameters schema.  This property must be provided in the input parameters when deploying an OVF package. This property will always be present in the result when retrieving information about an OVF package. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

