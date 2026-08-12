# Vcenter.Automation.OpenApi.Model.VcenterSystemConfigDeploymentTypeReconfigureSpec
The Vcenter.SystemConfig.DeploymentType.ReconfigureSpec schema contains the fields used to get and set the appliance type.  This schema was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of the appliance.  Possible values:   - &#x60;VCSA_EMBEDDED&#x60;: The vCenter Server Appliance with an embedded Platform Services Controller.   - &#x60;VCSA_EXTERNAL&#x60;: The vCenter Server Appliance with an external Platform Services Controller.   - &#x60;PSC_EXTERNAL&#x60;: An external Platform Services Controller.   For more information see: *Vcenter.Deployment.ApplianceType*.  This property was added in __vSphere API 6.7__. | 
**RemotePsc** | [**VcenterDeploymentRemotePscSpec**](VcenterDeploymentRemotePscSpec.md) | External PSC to register with when reconfiguring a VCSA_EMBEDDED appliance to a VCSA_EXTERNAL appliance.  This property was added in __vSphere API 6.7__.  Only required when reconfiguring an VCSA_EMBEDDED node to a VCSA_EXTERNAL. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

