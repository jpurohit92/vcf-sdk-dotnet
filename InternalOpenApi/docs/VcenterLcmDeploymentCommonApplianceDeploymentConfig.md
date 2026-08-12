# Vcenter.Automation.OpenApi.Model.VcenterLcmDeploymentCommonApplianceDeploymentConfig
The Vcenter.Lcm.Deployment.Common.ApplianceDeploymentConfig schema contains the new appliance deployment configuration.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SourceContainer** | [**VcenterLcmDeploymentCommonConnection**](VcenterLcmDeploymentCommonConnection.md) | A connection to container, which hosts the source appliance. This connection information is required for automatically extracting and preserving VM configuration during deployment, e.g. Virtual Ethernet Cards. If either the current vCenter is self managed or the VM configuration is not necessary to be preserved during deployment this field might be omitted.  This property was added in __vSphere API 9.0.0.0__.  Not required if the current VCenter is self managed. Otherwise if not set VM configuration won&#39;t be preserved. | [optional] 
**Appliance** | [**VcenterLcmDeploymentCommonApplianceDeployment**](VcenterLcmDeploymentCommonApplianceDeployment.md) | Description of the new appliance configuration.  This property was added in __vSphere API 9.0.0.0__. | 
**Location** | [**VcenterLcmDeploymentCommonLocation**](VcenterLcmDeploymentCommonLocation.md) | ESX or VC on which to deploy the appliance.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60; the target appliance will be deployed on the same location as current vCenter. If current vCenter is not self managed and source container is not specified, upgrade initialization will fail. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

