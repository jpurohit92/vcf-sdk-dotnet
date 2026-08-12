# Vcenter.Automation.OpenApi.Model.VcenterLcmDeploymentCommonLocation
The Vcenter.Lcm.Deployment.Common.Location schema contains configuration of appliance location.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Esx** | [**VcenterLcmDeploymentCommonEsx**](VcenterLcmDeploymentCommonEsx.md) | This section describes the ESX host on which to deploy the appliance. Required if you are deploying the appliance directly on an ESX host.  This property was added in __vSphere API 9.0.0.0__.  Mutual exclusive between esx and vcenter | [optional] 
**Vcenter** | [**VcenterLcmDeploymentCommonVCenter**](VcenterLcmDeploymentCommonVCenter.md) | This subsection describes the vCenter on which to deploy the appliance.  This property was added in __vSphere API 9.0.0.0__.  Mutual exclusive between esx and vcenter | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

