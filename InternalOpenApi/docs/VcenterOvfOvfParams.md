# Vcenter.Automation.OpenApi.Model.VcenterOvfOvfParams
The Vcenter.Ovf.OvfParams schema defines the common properties for all OVF deployment parameters. OVF parameters serve several purposes:     - Describe information about a given OVF package.    - Describe default deployment configuration.    - Describe possible deployment values based on the deployment environment.    - Provide deployment-specific configuration.   Each OVF parameters schema specifies a particular configurable aspect of OVF deployment. An aspect has both a query-model and a deploy-model. The query-model is used when the OVF package is queried, and the deploy-model is used when deploying an OVF package.    Most OVF parameter schemas provide both informational and deployment parameters. However, some are purely informational (for example, download size) and some are purely deployment parameters (for example, the flag to indicate whether registration as a vCenter extension is accepted).    See *POST /vcenter/ovf/library-item/{ovfLibraryItemId}?action=deploy* and *POST /vcenter/ovf/library-item/{ovfLibraryItemId}?action=filter*.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Unique identifier describing the type of the OVF parameters. The value is the name of the OVF parameters schema.  This property must be provided in the input parameters when deploying an OVF package. This property will always be present in the result when retrieving information about an OVF package. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

