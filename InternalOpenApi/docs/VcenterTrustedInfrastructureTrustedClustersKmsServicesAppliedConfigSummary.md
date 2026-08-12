# Vcenter.Automation.OpenApi.Model.VcenterTrustedInfrastructureTrustedClustersKmsServicesAppliedConfigSummary
This schema is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The Vcenter.TrustedInfrastructure.TrustedClusters.Kms.ServicesAppliedConfig.Summary schema contains basic information about the aggregated health status for a service.  This schema was added in __vSphere API 7.0.1.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Health** | **string** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The health value indicates whether the configuration applied to the cluster differs from the desired state.  Possible values:   - &#x60;NONE&#x60;: The consistency of the applied configuration is unknown.   - &#x60;OK&#x60;: The applied Key Provider Service configuration is consistent with the desired state.   - &#x60;ERROR&#x60;: The applied Key Provider Service configuration has diverged from the desired state.   For more information see: *Vcenter.TrustedInfrastructure.TrustedClusters.Kms.ServicesAppliedConfig.Health*.  This property was added in __vSphere API 7.0.1.0__. | 
**Address** | [**VcenterTrustedInfrastructureNetworkAddress**](VcenterTrustedInfrastructureNetworkAddress.md) | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The network address of the Key Provider Service configured for use in the Trusted Cluster.  This property was added in __vSphere API 7.0.1.0__. | 
**Service** | **string** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The unique identifier of a Key Provider Service configuration from the desired state.  This property was added in __vSphere API 7.0.1.0__.  If missing or &#x60;null&#x60;, this Key Provider Service is not registered within this vCenter and thus the applied configuration is not present in the desired state.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.trusted_infrastructure.kms.Service&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.trusted_infrastructure.kms.Service&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

