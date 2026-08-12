# Vcenter.Automation.OpenApi.Model.VcenterTrustedInfrastructureTrustedClustersServicesAppliedConfigInfo
This schema is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The Vcenter.TrustedInfrastructure.TrustedClusters.ServicesAppliedConfig.Info schema contains detailed information about the health of the applied Trust Authority Component configurations in a cluster.  This schema was added in __vSphere API 7.0.1.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Health** | **string** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The health value which indicates whether the configuration applied to the cluster differs from the desired state.  Possible values:   - &#x60;NONE&#x60;: The consistency of some applied configurations is unknown.   - &#x60;OK&#x60;: All the applied Trust Authority Component configurations are consistent with the desired state.   - &#x60;ERROR&#x60;: Some applied Trust Authority Component configurations have diverged from the desired state.   For more information see: *Vcenter.TrustedInfrastructure.TrustedClusters.ServicesAppliedConfig.Health*.  This property was added in __vSphere API 7.0.1.0__. | 
**Details** | [**List&lt;VapiStdLocalizableMessage&gt;**](VapiStdLocalizableMessage.md) | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  Details regarding the health. When the Vcenter.TrustedInfrastructure.TrustedClusters.ServicesAppliedConfig.Health is not *Vcenter.TrustedInfrastructure.TrustedClusters.ServicesAppliedConfig.Health.OK*, this member will provide a detailed description of the issues present.  This property was added in __vSphere API 7.0.1.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

