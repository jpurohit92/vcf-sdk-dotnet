# Vcenter.Automation.OpenApi.Model.VcenterOvfDeploymentOptionParams
The Vcenter.Ovf.DeploymentOptionParams schema describes the possible deployment options as well as the choice provided by the user.    This information based on the ovf:DeploymentOptionSection.    See *POST /vcenter/ovf/library-item/{ovfLibraryItemId}?action=deploy* and *POST /vcenter/ovf/library-item/{ovfLibraryItemId}?action=filter*.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeploymentOptions** | [**List&lt;VcenterOvfDeploymentOption&gt;**](VcenterOvfDeploymentOption.md) | List of deployment options. This property corresponds to the ovf:Configuration elements of the ovf:DeploymentOptionSection in the specification. It is a discrete set of intended resource allocation configurations from which one can be selected.  This property is not used in the input parameters when deploying an OVF package. This property will always be present in the result when retrieving information about an OVF package. | [optional] 
**SelectedKey** | **string** | The selected deployment option. Identifies the *Vcenter.Ovf.DeploymentOption* in the list in the deployment_options property with a matching value in the *Vcenter.Ovf.DeploymentOption.key* property.  This property is optional in the input parameters when deploying an OVF package. If missing or &#x60;null&#x60; the server will use the default deployment configuration, usually it&#39;s the first one in *Vcenter.Ovf.DeploymentOptionParams.deployment_options* list. This property is optional in the result when retrieving information about an OVF package. The value will be set only if it is specified with the optional ovf:default attribute. | [optional] 
**Type** | **string** | Unique identifier describing the type of the OVF parameters. The value is the name of the OVF parameters schema.  This property must be provided in the input parameters when deploying an OVF package. This property will always be present in the result when retrieving information about an OVF package. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

