# Vcenter.Automation.OpenApi.Model.VcenterOvfDeploymentOption
The Vcenter.Ovf.DeploymentOption schema contains the information about a deployment option as defined in the OVF specification.    This corresponds to the ovf:Configuration element of the ovf:DeploymentOptionSection in the specification. The ovf:DeploymentOptionSection specifies a discrete set of intended resource allocation configurations. This schema represents one item from that set.    See *POST /vcenter/ovf/library-item/{ovfLibraryItemId}?action=deploy* and *POST /vcenter/ovf/library-item/{ovfLibraryItemId}?action=filter*.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | The key of the deployment option, corresponding to the ovf:id attribute in the OVF descriptor.  This property is not used in the input parameters when deploying an OVF package. This property will always be present in the result when retrieving information about an OVF package. | [optional] 
**Label** | **string** | A localizable label for the deployment option.  This property is not used in the input parameters when deploying an OVF package. This property will always be present in the result when retrieving information about an OVF package. | [optional] 
**Description** | **string** | A localizable description for the deployment option.  This property is not used in the input parameters when deploying an OVF package. This property will always be present in the result when retrieving information about an OVF package. | [optional] 
**DefaultChoice** | **bool** | A boolean flag indicates whether this deployment option is the default choice.  This property is not used in the input parameters when deploying an OVF package. This property is optional in the result when retrieving information about an OVF package. If missing or &#x60;null&#x60; or false, it is not the default. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

